using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConsoleApplication
{
    public class Db
    {
        private MongoClient Client;
        public IMongoDatabase Database;

        public Db(string database = "assignment_2")
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
    }
}
