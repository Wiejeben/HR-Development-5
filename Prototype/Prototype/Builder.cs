using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Builder
    {
        public string Table = "";
        public bool Distrinct = false;
        public int? Limit;
        public List<WhereBuilder> Wheres = new List<WhereBuilder>();
    }
}
