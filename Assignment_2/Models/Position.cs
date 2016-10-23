namespace ConsoleApplication
{
    public class Position
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HourFee { get; set; }
        public int Hours { get; set; }

        public static Position Factory()
        {
            var position = new Position();

            position.Name = Faker.EducationCourse;
            position.Description = Faker.Scentence;
            position.HourFee = Faker.NumberBetween(10, 100);
            position.Hours = Faker.NumberBetween(1, 30);

            return position;
        }
    }
}