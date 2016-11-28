using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Set seed number
            Faker.SetSeed(11);

            // Clear collections
            Employee.Clear();
            Project.Clear();

            // Seed random data
            Project.Seed(1000);
            Employee.Seed(10000);

            // Calculate total amount of hours per employees
            var db = new Db();
            var employees = db.Table("employees");
            
            // Get only the employees that are working more dan 20 hours
            BsonJavaScript map = @"function() {
                this.Projects.forEach(function(project) {
                    var projectId = project.ProjectId;
                    var hours = 0;

                    project.Positions.forEach(function(position) {
                        hours += position.Hours;
                    });

                    if(hours > 20) {
                        emit(projectId, {count : 1}); 
                    }
                })
            }";

            // Group the overworking employees by project_id
            BsonJavaScript reduce = @"function(key, values) {
                var result = {count: 0};
                values.forEach(
                    function(value) {
                        result.count ++;
                    }
                );
                return result;
            }";

            // Set the MapReduce options
            var options = new MapReduceOptions<BsonDocument, BsonDocument>();
            options.OutputOptions = MapReduceOutputOptions.Inline;

            // Excute map and reduce functions 
            var resultMR = employees.MapReduce(map, reduce, options).ToList();

            // Print the results
            foreach (var result in resultMR)
            {
                Console.WriteLine("Project: " + result["_id"] + " has " + result["value"]["count"] + " overworking employees");
            }
        }
    }
}
