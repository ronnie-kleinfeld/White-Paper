using DLEFCore2.Repository;
using Microsoft.EntityFrameworkCore;

namespace DLEFCore2.Context {
    public class DLEFCoreContext : DbContext {
        // members
        public DbSet<UserModel> Users {
            get; set;
        }

        // class
        public DLEFCoreContext() {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        // events
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            //new NameMap().Configure(modelBuilder.Entity<NameModel>());

            base.OnModelCreating(modelBuilder);
        }
    }
}