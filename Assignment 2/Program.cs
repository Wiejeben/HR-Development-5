using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConsoleApplication
{
    public class Db
    {
        private MongoClient Client;
        private IMongoDatabase Database;

        public Db(string database = "local")
        {
            this.Client = new MongoClient();
            this.Database = this.Client.GetDatabase(database);
        }

        public IMongoCollection<BsonDocument> Table(string table)
        {
            return this.Database.GetCollection<BsonDocument>(table);
        }

        public List<BsonDocument> Find(string table)
        {
            return this.Table(table).Find(new BsonDocument()).ToList();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var db = new Db();

            // db.Table("employees").InsertOne(new BsonDocument
            // {
            //     { "_id", 12345678 },
            //     { "name", "Peter" },
            //     { "surname", "de Graaf" }
            // });


            // Update user
            db.Table("employees").UpdateOne(
                Builders<BsonDocument>.Filter.Eq("_id", 12345678),
                Builders<BsonDocument>.Update.Set("name", "Maarten").Set("surname", "Test")
            );

            // Get all documents
            foreach(BsonDocument entry in db.Find("employees"))
            {
                Console.WriteLine(entry.ToString());
            }

            Console.WriteLine("Done");
        }
    }
}
