using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // Insert
            var user = new User();
            user.Name = "Jan";
            user.LastName = "Jansen";
            user.Save();

            // Update
            user.Name = "Maarten-Jan";
            user.Save();

            Console.WriteLine("Current users: ");
            foreach (User entry in new User().All())
            {
                Console.WriteLine(entry.Id + " - " + entry.Name + " - " + entry.LastName);
            }

            // Delete
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
