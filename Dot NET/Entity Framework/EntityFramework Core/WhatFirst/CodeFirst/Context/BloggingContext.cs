using CodeFirst.Model;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Context {
    public class BloggingContext : DbContext {
        public DbSet<Blog> Blogs {
            get; set;
        }
        public DbSet<Post> Posts {
            get; set;
        }

        public BloggingContext() {
        }

        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
    }
}