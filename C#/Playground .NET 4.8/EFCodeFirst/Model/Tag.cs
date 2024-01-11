using System.Collections.Generic;

namespace EFCodeFirst.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }

        public Tag()
        {
            Courses = new List<Course>();
        }
    }
}