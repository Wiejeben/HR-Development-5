using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    interface Pivot
    {
        void AssignLeft(int value);
        bool Save();
        bool Delete();
    }
}
