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

            foreach (User entry in new User().All())
            {
                Console.WriteLine(entry.Name);
            }

            // Halt
            Console.ReadKey();
        }
    }
}
