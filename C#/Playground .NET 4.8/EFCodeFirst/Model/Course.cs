using System.Collections.Generic;

namespace EFCodeFirst.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevelEnum Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }

        public Course()
        {
            Tags = new List<Tag>();
        }
    }
}