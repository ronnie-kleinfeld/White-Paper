using System;
using System.Linq;

namespace EFDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new EFDatabaseFirstDBDBContext();
            var courses = dbContext.GetCourses();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }

            var author = dbContext.Authors.FirstOrDefault();
            var newCourse = new Course()
            {
                Title = "Entity Framework",
                LevelString = "Extreme",
                Author = author,
                Description = "EF 6 and Code"
            };
            dbContext.Courses.Add(newCourse);
            dbContext.SaveChanges();

            var count = dbContext.Courses.Count<Course>();
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}