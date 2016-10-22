using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Country : Model<Country>
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Country()
        {
            this.AutoIncrementColumn = "id";
            this.IdentifyingKeys.Add("id");
            this.Builder.Table = "countries";
        }
    }
}
