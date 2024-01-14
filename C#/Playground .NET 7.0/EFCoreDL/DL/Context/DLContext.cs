using Microsoft.EntityFrameworkCore;

namespace EFCoreDL.DL.Context {
    public class DLContext : DbContext {
        // members
        public DbSet<UserData> Users { get; set; } = null!;
        public DbSet<DepartmentTypeData> Departments { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EFCoreDL;Persist Security Info=True");
        }

        //// events
        //protected override void OnModelCreating(DbModelBuilder modelBuilder) {
        //    modelBuilder.Configurations.Add(new AuthorIDMap());
        //    modelBuilder.Configurations.Add(new UserIDMap());
        //    modelBuilder.Configurations.Add(new DepartmentTypeIDMap());
        //    modelBuilder.Configurations.Add(new GroupIDMap());

        //    base.OnModelCreating(modelBuilder);
        //}
    }
}