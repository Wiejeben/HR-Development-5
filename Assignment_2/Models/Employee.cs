using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Employee
    {
        public int Bsn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Headquarter Headquarter { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Degree> Degrees { get; set; } = new List<Degree>();
        public List<Position> Positions { get; set; } = new List<Position>();
        private static int _autoIncrement = 1;
        public static int AutoIncrement
        {
            get
            {
                return Employee._autoIncrement++;
            }
        }

        public static Employee Factory()
        {
            var employee = new Employee();

            employee.Bsn = Employee.AutoIncrement;
            employee.Name = Faker.FirstName;
            employee.Surname = Faker.LastName;
            employee.Headquarter = Headquarter.Factory();
            
            // Addresses
            for (var i = 0; i < Faker.NumberBetween(1, 4); i++)
            {
                employee.Addresses.Add(Address.Factory());
            }

            // Degrees
            for (var i = 0; i < Faker.NumberBetween(1, 4); i++)
            {
                employee.Degrees.Add(Degree.Factory());
            }

            // Positions
            for (var i = 0; i < Faker.NumberBetween(2, 6); i++)
            {
                employee.Positions.Add(Position.Factory());
            }

            return employee;
        }

        public static void Seed(int amount = 1)
        {
            var employees = new List<Employee>();

            for (var i = 0; i < amount; i++)
            {
                employees.Add(Employee.Factory());
            }

            // Insert all employees
            Employee.Db().Collection.InsertMany(employees);
        }

        public static void Clear()
        {
            Employee.Db().Clear();
        }

        private static Model<Employee> Db()
        {
            return new Model<Employee>("employees");
        }
    }
}