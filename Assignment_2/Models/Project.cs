using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Project
    {
        public int Budget { get; set; }
        public int AllocatedHours { get; set; }
        public Headquarter Headquarter { get; set; }
        public List<Position> Position { get; set; }
    }
}