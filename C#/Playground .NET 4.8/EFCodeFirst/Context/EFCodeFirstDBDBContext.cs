using EFCodeFirst.Model;
using System.Data.Entity;

namespace EFCodeFirst.Context
{
    public class EFCodeFirstDBDBContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        public EFCodeFirstDBDBContext()
        {

        }
    }
}