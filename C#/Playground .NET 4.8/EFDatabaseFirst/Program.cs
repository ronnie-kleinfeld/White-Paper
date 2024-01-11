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

            var count = dbContext.Courses.Count<Course>();
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}