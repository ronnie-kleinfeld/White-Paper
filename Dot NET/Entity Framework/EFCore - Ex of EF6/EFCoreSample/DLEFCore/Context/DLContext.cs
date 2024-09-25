using DLEFCore.Repository;
using Microsoft.EntityFrameworkCore;

namespace DLEFCore.Context {
    public class DLContext : DbContext {
        // members
        public DbSet<NameModel> Names {
            get; set;
        }
        public DbSet<NameIdModel> NameIds {
            get; set;
        }

        // class
        public DLContext() {
            //this.Configuration.LazyLoadingEnabled = false;
        }

        // events
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            new NameMap().Configure(modelBuilder.Entity<NameModel>());
            new NameIdMap().Configure(modelBuilder.Entity<NameIdModel>());
            new GenderTypeMap().Configure(modelBuilder.Entity<GenderTypeModel>());

            base.OnModelCreating(modelBuilder);
        }
    }
}