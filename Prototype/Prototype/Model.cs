using Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Prototype
{
    class Model<T> : IDisposable
    {
        public int Id { get; protected set; }
        protected Builder Builder;
        protected Db Connection;
        public bool Exists;

        public Model()
        {
            this.Builder = new Builder(this);

            // Automagically define table and column names
            this.Builder.Table = this.GenerateTableName();

            this.Connection = new Db(this.Builder);
        }

        public Model<T> Distinct()
        {
            this.Builder.Distrinct = true;

            return this;
        }

        private string GenerateTableName()
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

        public bool Save()
        {
            // Does not exist
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
                var type = this.GetType();
                T instance = (T) Activator.CreateInstance(type);
                
                // Set Exists field to true
                type.GetField("Exists").SetValue(instance, true);

                foreach (KeyValuePair<string, object> column in row)
                {
                    string propertyName = NameConversion.SnakeToPascal(column.Key);

                    // Get dynamic field
                    PropertyInfo property = type.GetProperty(propertyName);

                    if (property == null)
                    {
                        continue;
                    }

                    var value = column.Value;
                    var t = property.PropertyType;

                    // Set dynamic field value
                    property.SetValue(instance, Convert.ChangeType(column.Value, t));
                }

                results.Add(instance);
            }

            return results;
        }

        public static object ChangeType(object value, Type conversion)
        {
            var t = conversion;

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }

                t = Nullable.GetUnderlyingType(t);
            }

            return Convert.ChangeType(value, t);
        }

        // Update a record in the database.
        private bool Update()
        {
            if (!this.Connection.Update())
            {
                return false;
            }

            return true;
        }

        // Insert a record in the database.
        private bool Insert()
        {
            if (!this.Connection.Insert())
            {
                return false;
            }

            this.Id = this.Connection.LastInsertedId();
            this.Exists = true;
            return true;
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
            this.Connection.Dispose();
        }
    }
}
