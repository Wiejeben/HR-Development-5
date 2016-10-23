using System.Collections.Generic;
using MongoDB.Bson;

namespace ConsoleApplication
{
    public class ProjectReference
    {
        public ObjectId ProjectId { get; set; }
        public List<Position> Positions { get; set; } = new List<Position>();

        public static ProjectReference Factory()
        {
            var projectReference = new ProjectReference();

            projectReference.ProjectId = Project.GetRandom()._id;

            // Positions
            for (var i = 0; i < Faker.NumberBetween(1, 2); i++)
            {
                projectReference.Positions.Add(Position.Factory());
            }

            return projectReference;
        }
    }
}