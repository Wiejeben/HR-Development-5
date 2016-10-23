using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConsoleApplication
{
    public class Project : Collection
    {
        public ObjectId _id { get; set; }
        public int Budget { get; set; }
        public int AllocatedHours { get; set; }
        public Headquarter Headquarter { get; set; }

        public static Project Factory()
        {
            var project = new Project();

            project.Budget = Faker.NumberBetween(100, 10000000);
            project.AllocatedHours = Faker.NumberBetween(2, 100000);
            project.Headquarter = Headquarter.Factory();

            return project;
        }

        public static Project GetRandom()
        {
            IMongoCollection<Project> collection = Project.Db().Collection;

            int total = Convert.ToInt32(collection.Count(_ => true));

            int skip_amount = Faker.NumberBetween(1, total);

            return collection.Find(_ => true).Skip(skip_amount).First();
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

        public static Model<Project> Db()
        {
            return new Model<Project>("projects");
        }
    }
}