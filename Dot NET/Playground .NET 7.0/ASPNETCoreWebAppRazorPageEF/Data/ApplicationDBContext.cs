using ASPNETCoreWebAppRazorPageEF.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAppRazorPageEF.Data {
    public class ApplicationDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
        }
    }
}