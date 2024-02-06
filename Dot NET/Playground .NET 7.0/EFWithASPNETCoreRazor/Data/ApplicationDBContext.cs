using EFWithASPNETCoreRazor.Data.Model;
using Microsoft.EntityFrameworkCore;

namespace EFWithASPNETCoreRazor.Data {
    public class ApplicationDBContext : DbContext {
        public DbSet<Movie> Movies { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {
        }
    }
}