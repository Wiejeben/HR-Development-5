using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Course : Model<Course>
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public Course()
        {
            this.AutoIncrementColumn = "id";
            this.PrimaryKey = "id";
        }
    }
}
