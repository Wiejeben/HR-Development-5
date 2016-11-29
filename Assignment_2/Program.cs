using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter seed (number): ");
            int seed = Convert.ToInt32(Console.ReadLine());
            
            // // Set seed number
            Faker.SetSeed(seed);

            // Clear collections
            Employee.Clear();
            Project.Clear();

            // Seed random data
            Project.Seed(1000);
            Employee.Seed(10000);

            // Show results
            Assignment.Overworking();

            // Halt
            Console.ReadKey();
        }
    }
}
