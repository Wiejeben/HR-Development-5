using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class City : Model<City>
    {
        public int Id { get; private set; }
        public int ProvinceId { get; set; }
        public string Name { get; set; }

        private Province _province;
        public Province Province
        {
            get
            {
                if (this._province == null)
                {
                    this._province = new Province().Find(this.ProvinceId.ToString());
                }

                return this._province;
            }
        }

        public City()
        {
            this.AutoIncrementColumn = "id";
            this.IdentifyingKeys.Add("id");
            this.Builder.Table = "cities";
        }
    }
}
