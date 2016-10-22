using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Address : Model<Address>
    {
        public int Id { get; private set; }
        public int StreetId { get; set; }
        public int Number { get; set; }
        public string Addition { get; set; }
        public string PostalCode { get; set; }

        private Street _street;

        public Street Street
        {
            get
            {
                if (this._street == null)
                {
                    this._street = new Street().Find(this.StreetId.ToString());
                }

                return this._street;
            }
        }

        public Address()
        {
            this.AutoIncrementColumn = "id";
            this.PrimaryKey = "id";
            this.Builder.Table = "addresses";
        }
    }
}
