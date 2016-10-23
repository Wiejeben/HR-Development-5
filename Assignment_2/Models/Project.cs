using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class Project
    {
        public int Budget { get; set; }
        public int AllocatedHours { get; set; }
        public Headquarter Headquarter { get; set; }
        public List<Position> Position { get; set; }

        public static Project Factory()
        {
            var project = new Project();

            project.Budget = Faker.NumberBetween(100, 10000000);
            project.AllocatedHours = Faker.NumberBetween(2, 100000);

            return project;
        }

        public static void Seed(int amount = 1)
        {
            var projects = new List<Project>();

            for (var i = 0; i < amount; i++)
            {
                projects.Add(Project.Factory());
            }

            // Insert all projects
            Project.Db().Collection.InsertMany(projects);
        }

        public static void Clear()
        {
            Project.Db().Clear();
        }

        private static Model<Project> Db()
        {
            return new Model<Project>("projects");
        }
    }
}