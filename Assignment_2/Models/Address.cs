namespace ConsoleApplication
{
    public class Address
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Addition { get; set; }
        public string PostalCode { get; set; }
        public bool Residence { get; set; }

        public static Address Factory(bool residence = false)
        {
            var address = new Address();

            address.Country = Faker.Country;
            address.City = Faker.City;
            address.Street = Faker.StreetName;
            address.Number = Faker.NumberBetween(1, 400);
            address.Addition = Faker.RandomLetter.ToString();
            address.PostalCode = Faker.NumberBetween(1000, 9999).ToString() + Faker.RandomLetter.ToString().ToUpper() + Faker.RandomLetter.ToString().ToUpper();
            address.Residence = residence;

            return address;
        }
    }
}