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

        public Db(string database = "assignment2")
        {
            this.Client = new MongoClient();
            this.Database = this.Client.GetDatabase(database);
        }

        /**
            Clear all collections.
        */
        public void Clear()
        {
            this.Database.DropCollectionAsync("employees");
            this.Database.DropCollectionAsync("projects");
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
}
