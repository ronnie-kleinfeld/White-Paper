using ASPNETCoreWebAppMVCEF.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNETCoreWebAppMVCEF.Data {
    public class ApplicationDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
        }
    }
}