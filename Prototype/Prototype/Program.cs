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
            using (User data = new User())
            {
                foreach (User user in data.All())
                {
                    Console.WriteLine(user.Name);
                }
            }

            Console.WriteLine("---");

            using (User data = new User())
            {
                User user = data.Find(2);
                
                Console.WriteLine(user.Name);
            }

            // Halt
            Console.ReadKey();
        }
    }
}
