using MongoDB.Driver;

namespace ConsoleApplication
{
    public class Model<T>
    {
        private Db Db;
        private string Table;
        public IMongoCollection<T> Collection
        {
            get
            {
                return this.Db.Database.GetCollection<T>(this.Table);
            }
        }

        public Model(string table)
        {
            this.Db = new Db();
            this.Table = table;
        }

        public void Clear()
        {
            this.Db.Database.DropCollection(this.Table);
        }
        
    }
}
