﻿using System;
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

        public List<KeyValuePair<string, string>> Columns(bool excludeWriteOnly = false)
        {
            var results = new List<KeyValuePair<string, string>>();
            var properties = this.Model.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (excludeWriteOnly && property.GetSetMethod() == null)
                {
                    continue;
                }

                var name = NameConversion.PascalToSnake(property.Name);
                results.Add(new KeyValuePair<string, string>(name, property.GetValue(this.Model).ToString()));
            }

            return results;
        }
    }
}
