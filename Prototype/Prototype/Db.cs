using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Db
    {
        private MySqlConnection Connection = new MySqlConnection();
        private string ConnectionString = "server=localhost;uid=root;pwd=root;database=orm;";
        private Builder Builder;
        private string QueryString;

        public Db(Builder builder)
        {
            // Connect to DB
            try
            {
                Connection.ConnectionString = ConnectionString;
                Connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Unable to connect to the database.");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

            this.Builder = builder;
        }

        public List<Dictionary<string, object>> Get()
        {
            // Action
            this.QueryString = "SELECT ";

            // Columns
            this.QueryString += "* ";

            // Table
            this.QueryString += "FROM `" + this.Builder.Table + "` ";

            if (this.Builder.Wheres.Count > 0)
            {
                this.QueryString += "WHERE ";

                int i = 0;
                foreach (WhereBuilder where in this.Builder.Wheres)
                {
                    if (i > 0)
                    {
                        this.QueryString += where.Boolean + " ";
                    }

                    this.QueryString += "`" + where.Column + "` " + where.Operator + " '" + where.Value + "' ";

                    i++;
                }
            }


            Console.WriteLine(this.QueryString);
            return this.ExecuteGet(this.QueryString);
        }

        private List<Dictionary<string, object>> ExecuteGet(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, this.Connection);
            var reader = cmd.ExecuteReader();

            var results = new List<Dictionary<string, object>>();

            // Convert Reader to Dictionary
            while (reader.Read())
            {
                var result = new Dictionary<string, object>();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    result.Add(reader.GetName(i), reader.GetValue(i));
                }

                results.Add(result);
            }

            return results;
        }
    }
}
