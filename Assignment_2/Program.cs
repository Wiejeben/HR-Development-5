namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Faker.SetSeed(11);

            Employee.Seed(1);
        }
    }
}
