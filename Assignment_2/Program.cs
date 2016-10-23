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
            Employee.Seed(10000);
            Project.Seed(100);
        }
    }
}
