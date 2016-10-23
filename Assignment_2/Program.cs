namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set seed number
            Faker.SetSeed(11);

            // Clear collections
            Employee.Clear();
            Project.Clear();

            // Seed random data
            Project.Seed(1000);
            Employee.Seed(10000);
        }
    }
}
