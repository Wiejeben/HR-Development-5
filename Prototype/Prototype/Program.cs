using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Name = "Maarten";
            user.LastName = "De Graaf";

            Console.WriteLine(user.Save().ToString());

            // Halt
            Console.ReadKey();
        }
    }
}
