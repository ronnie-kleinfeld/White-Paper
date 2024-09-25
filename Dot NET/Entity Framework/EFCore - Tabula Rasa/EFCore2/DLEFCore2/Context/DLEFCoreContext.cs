using DLEFCore2.Repository;
using DLEFCore2.Repository.Samples;
using Microsoft.EntityFrameworkCore;

namespace DLEFCore2.Context {
    public class DLEFCoreContext : DbContext {
        // members
        public DbSet<EntityIdModel> EntitesId {
            get; set;
        }
        public DbSet<EntityNoIdModel> EntitesNoId {
            get; set;
        }
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
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCore2DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<UserModel>()
                .Property(user => user.Name1)
                .HasDefaultValue("Ronnie");

            modelBuilder.Entity<UserModel>()
                .Property(e => e.CreatedDateTime1)
                .HasDefaultValueSql("GETDATE()");

            base.OnModelCreating(modelBuilder);
        }
    }
}