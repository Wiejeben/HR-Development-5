using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Street : Model<Street>
    {
        public int Id { get; private set; }
        public int CityId { get; set; }
        public string Name { get; set; }

        private City _city;
        public City City
        {
            get
            {
                if (this._city == null)
                {
                    this._city = new City().Find(this.CityId.ToString());
                }

                return this._city;
            }
        }

        public Street()
        {
            this.AutoIncrementColumn = "id";
            this.PrimaryKey = "id";
        }
    }
}
