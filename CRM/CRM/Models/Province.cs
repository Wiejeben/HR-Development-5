using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Province : Model<Province>
    {
        public int Id { get; private set; }
        public int CountryId { get; set; }
        public string Name { get; set; }

        private Country _country;
        public Country Country
        {
            get
            {
                if (this._country == null)
                {
                    this._country = new Country().Find(this.CountryId.ToString());
                }

                return this._country;
            }
        }

        public Province()
        {
            this.AutoIncrementColumn = "id";
            this.IdentifyingKeys.Add("id");
        }
    }
}
