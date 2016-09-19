using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class User : Model<User>
    {
        public int Id;
        public string Name;
        public string LastName;
    }
}
