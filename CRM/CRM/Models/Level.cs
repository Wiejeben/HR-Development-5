using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Level : Model<Level>
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Level()
        {
            this.AutoIncrementColumn = "id";
            this.IdentifyingKeys.Add("id");
        }
    }
}
