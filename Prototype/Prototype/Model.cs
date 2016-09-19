using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Model<T> : IDisposable
    {
        protected Builder Builder = new Builder();
        protected Db Connection;
        private FieldInfo[] Fields;
        public bool Exists = false;

        public Model()
        {
            // Automagically define table and column names
            this.Builder.Table = this.GetTableName();
            this.Fields = this.GetType().GetFields();

            this.Connection = new Db(this.Builder);
        }

        public Model<T> Distinct()
        {
            this.Builder.Distrinct = true;

            return this;
        }

        private string GetTableName()
        {
            return this.GetType().Name.ToLower() + "s";
        }

        public Model<T> Where(string column, string @operator, string value, string boolean = "and")
        {
            WhereBuilder build = new WhereBuilder();

            build.Column = column;
            build.Operator = @operator;
            build.Value = value;
            build.Boolean = boolean;

            this.Builder.Wheres.Add(build);

            return this;
        }

        public Model<T> OrWhere(string column, string @operator, string value)
        {
            return this.Where(column, @operator, value, "or");
        }

        public List<T> All()
        {
            return this.Get();
        }

        public Model<T> Limit(int value)
        {
            this.Builder.Limit = value;

            return this;
        }

        public Model<T> Take(int value)
        {
            return this.Limit(value);
        }

        public T Find(int id)
        {
            return this.Where("id", "=", id.ToString()).First();
        }

        public T First()
        {
            return this.Take(1).Get().FirstOrDefault();
        }

        public int Min(string column)
        {
            // Execute MIN query on given column

            return 0;
        }

        public int Max(string column)
        {
            // Execute MAX query on given column

            return 0;
        }

        public int Sum(string column)
        {
            // Execute SUM query on given column

            return 0;
        }

        public int Avg(string column)
        {
            // Execute AVG query on given column

            return 0;
        }

        public bool Save()
        {
            if (!this.Exists)
            {
                return this.Insert();
            }

            return this.Update();
        }

        // Execute the query as a "select" statement.
        public List<T> Get()
        {
            // Execute SELECT query          
            return this.Generate(this.Connection.Get());
        }

        private List<T> Generate(List<Dictionary<string, object>> rows)
        {
            var results = new List<T>();

            // Row
            foreach (Dictionary<string, object> row in rows)
            {
                T instance = (T) Activator.CreateInstance(this.GetType());
                
                // Set Exists field to true
                FieldInfo exists = instance.GetType().GetField("Exists");
                exists.SetValue(instance, true);

                foreach (KeyValuePair<string, object> column in row)
                {
                    string propertyName = NameConversion.SnakeToPascal(column.Key);

                    // Set dynamic field with correct type
                    FieldInfo property = instance.GetType().GetField(propertyName);
                    property.SetValue(instance, Convert.ChangeType(column.Value, property.FieldType));
                }

                results.Add(instance);
            }

            return results;
        }

        // Update a record in the database.
        public bool Update()
        {
            // Execute UPDATE query
            
            return false;
        }

        // Insert a record in the database.
        public bool Insert()
        {
            // Execute INSERT query

            this.Exists = true;
            return false;
        }

        // Delete a record from the database.
        public bool Delete()
        {
            // Execute DELETE query

            this.Exists = false;
            return false;
        }

        public void Dispose()
        {
            
        }
    }
}
