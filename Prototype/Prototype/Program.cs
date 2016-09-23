using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();

            user.Name = "Kyra";
            user.LastName = "de Graaf";
            user.Save();

            using (var entries = new User())
            {
                foreach(User entry in entries.All())
                {
                    Console.WriteLine(entry.Name);
                }
            }

            // Halt
            Console.ReadKey();
        }
    }
}
