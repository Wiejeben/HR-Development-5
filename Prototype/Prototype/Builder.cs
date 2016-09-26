using System;
using System.Collections.Generic;
using System.Reflection;

namespace Prototype
{
    class Builder
    {
        public string Table = "";
        public bool Distrinct = false;
        public int? Limit;
        public List<WhereBuilder> Wheres = new List<WhereBuilder>();
        public object Model;

        public Builder(object model)
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
    }
}
