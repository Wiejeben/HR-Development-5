using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User();
            user.Name = "Test";
            user.Save();

            user.Name = "Test worked";
            user.Save();

            Console.WriteLine("Current users: ");
            foreach (User entry in new User().All())
            {
                Console.WriteLine(entry.Id + " - " + entry.Name + " - " + entry.LastName);
            }

            user.Delete();

            Console.WriteLine("Current users: ");
            foreach (User entry in new User().All())
            {
                Console.WriteLine(entry.Id + " - " + entry.Name + " - " + entry.LastName);
            }

            // Halt
            Console.ReadKey();
        }
    }
}
