using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class School : Model<School>
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public School()
        {
            this.AutoIncrementColumn = "id";
            this.PrimaryKey = "id";
        }
    }
}
