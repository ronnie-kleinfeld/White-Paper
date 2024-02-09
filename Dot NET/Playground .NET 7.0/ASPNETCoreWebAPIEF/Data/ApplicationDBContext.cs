using ASPNETCoreWebAPIEF.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAPIEF.Data {
    public class ApplicationDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
        }
    }
}