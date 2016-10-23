using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Employee : Collection
    {
        public int _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Headquarter Headquarter { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();
        public List<Degree> Degrees { get; set; } = new List<Degree>();
        public List<ProjectReference> Projects { get; set; } = new List<ProjectReference>();
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

            employee._id = Employee.AutoIncrement;
            employee.Name = Faker.FirstName;
            employee.Surname = Faker.LastName;
            employee.Headquarter = Headquarter.Factory();
            
            // Addresses
            for (var i = 0; i < Faker.NumberBetween(1, 4); i++)
            {
                // First address will always be the residence
                employee.Addresses.Add(Address.Factory((i == 0)));
            }

            // Degrees
            for (var i = 0; i < Faker.NumberBetween(2, 4); i++)
            {
                employee.Degrees.Add(Degree.Factory());
            }

            // Projects
            for (var i = 0; i < Faker.NumberBetween(1, 4); i++)
            {
                employee.Projects.Add(ProjectReference.Factory());
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

        public static Model<Employee> Db()
        {
            return new Model<Employee>("employees");
        }
    }
}