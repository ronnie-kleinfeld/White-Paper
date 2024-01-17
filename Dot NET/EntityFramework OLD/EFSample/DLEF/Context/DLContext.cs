using DLEF.Handlers;
using System.Data.Entity;

namespace DLEF.Context {
    public class DLContext : DbContext {
        // members
        public DbSet<AuthorData> Authors { get; set; }
        public DbSet<DepartmentTypeData> Departments { get; set; }
        public DbSet<GroupData> Groups { get; set; }
        public DbSet<UserData> Users { get; set; }

        // class
        public DLContext() : base("name=ConnectionString") {
            this.Configuration.LazyLoadingEnabled = false;
        }

        // events
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Configurations.Add(new AuthorIDMap());
            modelBuilder.Configurations.Add(new UserIDMap());
            modelBuilder.Configurations.Add(new DepartmentTypeIDMap());
            modelBuilder.Configurations.Add(new GroupIDMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}