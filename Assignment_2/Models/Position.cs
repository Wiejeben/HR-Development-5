namespace ConsoleApplication
{
    public class Position
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HourFee { get; set; }

        public static Position Factory()
        {
            var position = new Position();

            position.Name = Faker.EducationCourse;
            position.Description = Faker.Scentence;
            position.HourFee = Faker.NumberBetween(1, 40);

            return position;
        }
    }
}