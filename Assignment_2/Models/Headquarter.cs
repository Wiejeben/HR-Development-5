namespace ConsoleApplication
{
    public class Headquarter
    {
        public string Name { get; set; }
        public int NumberOfRooms { get; set; }
        public int MonthlyRent { get; set; }
        public Address Address { get; set; }

        public static Headquarter Factory()
        {
            var headquarter = new Headquarter();

            headquarter.Name = Faker.BuildingName;
            headquarter.NumberOfRooms = Faker.NumberBetween(2, 200);
            headquarter.MonthlyRent = Faker.NumberBetween(1000, 100000);
            headquarter.Address = Address.Factory();

            return headquarter;
        }
    }
}