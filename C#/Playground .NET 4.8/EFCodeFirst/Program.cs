using EFCodeFirst.Context;
using System;
using System.Linq;

namespace EFCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new EFCodeFirstDBDBContext();

            var course = dbContext.Courses.FirstOrDefault();
            Console.WriteLine(course);
            Console.ReadKey();
        }
    }
}