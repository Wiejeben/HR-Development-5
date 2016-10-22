using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Position : Model<Position>
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float HourFee { get; set; }

        public Position()
        {
            this.AutoIncrementColumn = "id";
            this.IdentifyingKeys.Add("id");
        }
    }
}
