using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace CRM
{
    class Db : IDisposable
    {
        private MySqlConnection Connection = new MySqlConnection();
        private string ConnectionString = "server=192.168.1.144;uid=root;pwd=root;database=employee_manager;";
        private Builder Builder;
        private string QueryString;

        public Db(Builder builder)
        {
            // Connect to DB
            //try
            //{
                Connection.ConnectionString = ConnectionString;
                Connection.Open();
            //}
            //catch (MySqlException ex)
            //{
            //    Console.WriteLine("Unable to connect to the database.");
            //    Console.WriteLine(ex.Message);
            //    Console.ReadKey();
            //}

            this.Builder = builder;
        }
        

        public List<Dictionary<string, object>> Get(List<string> columns = null)
        {
            // Action
            this.QueryString = "SELECT ";

            if (this.Builder.Distrinct)
            {
                this.QueryString += "DISTINCT ";
            }

            // Add default columns
            if (columns == null)
            {
                columns = new List<string>();
                columns.Add("*");
            }

            // Implement columns
            foreach (string column in columns)
            {
                this.QueryString += column + " ";
            }

            // Table
            this.QueryString += "FROM `" + this.Builder.Table + "` ";

            // Wheres
            this.QueryString += this.BuildWheres();

            // Limit
            if (this.Builder.Limit != null)
            {
                this.QueryString += "LIMIT " + this.Builder.Limit + " ";
            }

            // End
            this.QueryString = this.QueryString.Trim() + ";";

            return this.Read();
        }

        private string BuildWheres()
        {
            string result = "";

            // Where
            if (this.Builder.Wheres.Count > 0)
            {
                result += "WHERE ";

                int i = 0;
                foreach (WhereBuilder where in this.Builder.Wheres)
                {
                    if (i > 0)
                    {
                        result += where.Boolean + " ";
                    }

                    result += "`" + where.Column + "` " + where.Operator + " '" + where.Value + "' ";

                    i++;
                }
            }

            return result;
        }

        private List<Dictionary<string, object>> Read()
        {
            Console.WriteLine(this.QueryString);
            MySqlCommand cmd = new MySqlCommand(this.QueryString, this.Connection);

            var results = new List<Dictionary<string, object>>();
            
            using (var reader = cmd.ExecuteReader())
            {
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
            }

            return results;
        }

        private int Execute()
        {
            Console.WriteLine(this.QueryString);
            MySqlCommand cmd = new MySqlCommand(this.QueryString, this.Connection);

            return cmd.ExecuteNonQuery();
        }

        public bool Insert()
        {
            Dictionary<string, string> columns = this.Builder.Columns(this.Builder.Model.HasAutoIncrement());

            // Start query string
            this.QueryString = "INSERT INTO `" + this.Builder.Table + "` ";

            // Columns
            this.QueryString += "(";

            foreach (var column in columns)
            {
                this.QueryString += "`" + column.Key + "`, ";
            }
            this.QueryString = this.QueryString.TrimEnd(new char[] { ',', ' ' });

            this.QueryString += ") ";

            // Values
            this.QueryString += "VALUES(";

            foreach(var column in columns)
            {
                this.QueryString += "'" + column.Value + "', ";
            }
            this.QueryString = this.QueryString.TrimEnd(new char[] { ',', ' ' });

            this.QueryString += ")";

            // End query
            this.QueryString += ";";

            // Rows effected
            return (this.Execute() > 0);
        }

        public int LastInsertedId()
        {
            this.QueryString = "SELECT LAST_INSERT_ID() as `id`;";

            var results = this.Read();

            if (results.Count == 0)
            {
                return -1;
            }

            return Convert.ToInt32(results[0]["id"]);
        }

        public bool Update()
        {
            Dictionary<string, string> columns = this.Builder.Columns(true);
           
            // Start query string
            this.QueryString = "UPDATE `" + this.Builder.Table + "` ";

            // Columns
            this.QueryString += "SET ";

            foreach (var column in columns)
            {
                this.QueryString += "`" + column.Key + "` = '" + column.Value + "', ";
            }
            this.QueryString = this.QueryString.TrimEnd(new char[] { ',', ' ' });
            
            // Which entry to update
            this.QueryString += " WHERE `" + this.Builder.Model.PrimaryKey + "` = '" + this.Builder.Columns()[this.Builder.Model.PrimaryKey] + "'";

            // End query
            this.QueryString += ";";

            // Rows effected
            return (this.Execute() > 0);
        }

        public bool Delete()
        {
            this.QueryString = "DELETE FROM `" + this.Builder.Table + "` ";

            // Wheres
            this.QueryString += this.BuildWheres();

            // Rows effected
            return (this.Execute() > 0);
        }

        public void Dispose()
        {
            this.Connection.Close();
        }
    }
}
