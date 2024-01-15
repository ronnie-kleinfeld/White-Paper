using EFCoreDL.DL.Model;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDL.DL.Context {
    public class DLContext : DbContext {
        // members
        public DbSet<UserModel> Users { get; set; } = null!;
        public DbSet<DepartmentTypeModel> Departments { get; set; } = null!;
        public DbSet<CustomerModel> Customers { get; set; } = null!;
        public DbSet<OrderData> Orders { get; set; } = null!;
        public DbSet<ProductModel> Products { get; set; } = null!;
        public DbSet<OrderDetailModel> OrderDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=EFCoreDLDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
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