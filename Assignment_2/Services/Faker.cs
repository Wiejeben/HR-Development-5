using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public static class Faker
    {
        private static Random _random;
        private static Random Random
        {
            get
            {
                if (Faker._random == null)
                {
                    throw new Exception("Must first define seed via `Faker.SetSeed(int seed)`.");
                }

                return Faker._random;
            }

            set
            {
                Faker._random = value;
            }
        }

        public static void SetSeed(int seed)
        {
            Faker.Random = new Random(seed);

            Console.WriteLine("--- Running on seed: " + seed.ToString() + " ---");
        }

        public static int NumberBetween(int min, int max)
        {
            return Faker.Random.Next(min, max);
        }

        public static char RandomLetter
        {
            get
            {
                char[] options = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string StreetName
        {
            get
            {
                string[] options = new string[] { "Wegastraat", "Prinses Annalaan", "Wijnhaven", "Beurs" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string City
        {
            get
            {
                string[] options = new string[] { "Den Haag", "Leiden", "Rotterdam", "Leidschendam", "Delft", "Amsterdam", "Utrecht", "Voorburg" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string Country
        {
            get
            {
                string[] options = new string[] { "Nederland", "België", "Duitsland", "Amerika", "Engeland", "Scotland", "Frankrijk" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string FirstName
        {
            get
            {
                string[] options = new string[] { "Maarten", "Andy", "Dilan", "Remco", "Sjoerd", "Berend", "Stephan", "Jeffrey", "Pascal", "Jan" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string LastName
        {
            get
            {
                string[] options = new string[] { "de Graaf", "Bhadai", "Leeuwendaal", "Jansen", "van der Hoeven", "van Dorp", "van der Meer", "van Tilburg", "Meijer" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string BuildingName
        {
            get
            {
                string[] options = new string[] { "Gebouw 1A", "Gebouw 1B", "Gebouw 2", "Gebouw 3", "Gebouw 4A", "Gebouw 4B" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string EducationFacility
        {
            get
            {
                string[] options = new string[] { "Hogeschool Rotterdam", "Hogeschool Leiden", "Hogeschool Amsterdam", "Hogeschool Utrecht", "Hogeschool Maastricht", "Hogeschool Twente" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string EducationLevel
        {
            get
            {
                string[] options = new string[] { "MBO 2", "MBO 3", "MBO 4", "HBO" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string EducationCourse
        {
            get
            {
                string[] options = new string[] { "Informatica", "Verzorging", "Business and Management", "Mediatechnologie", "Automonteur" };
                return options[Faker.Random.Next(options.Length)];
            }
        }

        public static string Scentence
        {
            get
            {
                string[] options = new string[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit.", "Fusce sit amet turpis ac justo placerat molestie. Aenean tortor metus, semper sed consectetur id, scelerisque ut nisi.", "Curabitur rutrum mollis diam, sed tincidunt orci dignissim sit amet.", "Integer lorem velit, feugiat vel volutpat eu, tincidunt id eros.", "Pellentesque sem turpis, dictum at commodo vel, rutrum eget enim." };
                return options[Faker.Random.Next(options.Length)];
            }
        }
    }
}