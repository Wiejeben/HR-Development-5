using System;
using System.Collections.Generic;
using System.Reflection;

namespace CRM
{
    public class Builder
    {
        public string Table = null;
        public bool Distrinct = false;
        public int? Limit;
        public List<WhereBuilder> Wheres = new List<WhereBuilder>();
        public Model Model;

        public Builder(Model model)
        {
            this.Model = model;
        }

        public Dictionary<string, string> Columns(bool excludeWriteOnly = false)
        {
            var results = new Dictionary<string, string>();
            var properties = this.Model.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (excludeWriteOnly && property.GetSetMethod() == null)
                {
                    continue;
                }

                var name = NameConversion.PascalToSnake(property.Name);
                var value = property.GetValue(this.Model);

                if (value == null)
                {
                    continue;
                }

                results.Add(name, value.ToString());
            }

            return results;
        }

        public void AppendIdentifyingKeys()
        {
            var columns = this.Columns();
            foreach(var key in this.Model.IdentifyingKeys)
            {
                WhereBuilder where = new WhereBuilder();

                where.Column = key;
                where.Operator = "=";
                where.Value = columns[key];
                where.Boolean = "and";

                this.Wheres.Add(where);
            }
        }
    }
}
