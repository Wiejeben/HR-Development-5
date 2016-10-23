namespace ConsoleApplication
{
    public class Degree
    {
        public string School { get; set; }
        public string Level { get; set; }
        public string Course { get; set; }

        public static Degree Factory()
        {
            var degree = new Degree();

            degree.School = Faker.EducationFacility;
            degree.Level = Faker.EducationLevel;
            degree.Course = Faker.EducationCourse;

            return degree;
        }
    }
}