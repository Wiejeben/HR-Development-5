using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Builder
    {
        public bool Distrinct = false;
        public int Limit;
        public List<WhereBuilder> Wheres;
    }

    class WhereBuilder
    {
        public string Column;
        public string Operator;
        public string Value;
        public string Boolean;
    }

    class Model
    {
        protected Builder Builder;
        protected string Table = "";
        private FieldInfo[] Fields;

        public Model()
        {
            this.Builder = new Builder();

            // Automagically define table and column names
            this.Table = this.GetType().Name;
            this.Fields = this.GetType().GetFields();
        }

        public Model Distinct()
        {
            this.Builder.Distrinct = true;

            return this;
        }

        public Model Where(string column, string @operator, string value, string boolean = "and")
        {
            WhereBuilder build = new WhereBuilder();

            build.Column = column;
            build.Operator = @operator;
            build.Value = value;
            build.Boolean = boolean;

            this.Builder.Wheres.Add(build);

            return this;
        }

        public Model OrWhere(string column, string @operator, string value)
        {
            return this.Where(column, @operator, value, "or");
        }

        public List<Model> All()
        {
            return new List<Model>();
        }

        public Model Limit(int value)
        {
            this.Builder.Limit = value;

            return this;
        }

        public Model Take(int value)
        {
            return this.Limit(value);
        }

        public Model Find(int id)
        {
            return this.Where("id", "=", id.ToString()).First();
        }

        public Model First()
        {
            return this.Take(1).Get().First();
        }

        public List<Model> Get()
        {
            return new List<Model>();
        }

        public bool Exists()
        {
            return false;
        }

        public int Count()
        {
            return 0;
        }

        public int Min(string column)
        {
            return 0;
        }

        public int Max(string column)
        {
            return 0;
        }

        public int Sum(string column)
        {
            return 0;
        }

        public int Avg(string column)
        {
            return 0;
        }

        public bool Save()
        {
            return false;
        }

        public bool Update(Dictionary<string, string> values)
        {
            return false;
        }

        public bool Insert(Dictionary<string, string> values)
        {
            return false;
        }

        public bool Delete()
        {
            return false;
        }
    }
}
