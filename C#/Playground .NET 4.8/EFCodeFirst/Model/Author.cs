using System.Collections.Generic;

namespace EFCodeFirst.Model
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }

        public Author()
        {
            Courses = new List<Course>();
        }
    }
}