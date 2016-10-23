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

            // GET all employees
            // GET all projects

            // var projects = Project.Db().Collection;

            // // Calculate total amount of hours per employees

            // //Mapper function for the collection
			// BsonJavaScript map = @"function() {
            //     emit(this._id, this._id);
            // }";

			// //Reduce function which does nothing than returning the result 
			// BsonJavaScript reduce = @"function(key, results) {

            //     return 20;
            // }";

			// //Options for the result of the output
			// var options = new MapReduceOptions<Project, BsonDocument> ();
			// options.OutputOptions = MapReduceOutputOptions.Inline;

			// //Excute map and reduce functions 
			// BsonDocument results = projects.MapReduce (map, reduce, options).First();

			// //print first result only  
			// Console.WriteLine(results);


            // // SUM total amount of working hours

            // // IF total amount of hours is more then 20
            // // +1 Dictionary<Project, int> where Project ObjectId is the same

            // // Foreach results
        }
    }
}
