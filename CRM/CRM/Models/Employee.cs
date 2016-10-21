using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    class Employee : Model<Employee>
    {
        public int Bsn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public Employee()
        {
            this.PrimaryKey = "bsn";
        }
    }
}
