using DLEFCore.Context;
using DLEFCore.Repository.Base;
using DLEFCore.Repository.Base.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLEFCore.Repository {
    public interface IDepartmentTypeRepository : IRepository<DepartmentTypeModel> {
    }
    public class _DepartmentTypeRepository : Repository<DepartmentTypeModel>, IDepartmentTypeRepository {
        public _DepartmentTypeRepository(DLContext context) : base(context) {
        }
    }

    internal class DepartmentTypeEntityTypeConfiguration : IEntityTypeConfiguration<DepartmentTypeModel> {
        public void Configure(EntityTypeBuilder<DepartmentTypeModel> builder) {
            builder.ToTable("Departments");
            builder.Property(v => v.Name).IsRequired().HasMaxLength(255);
            builder.Property(v => v.Description).IsRequired().HasMaxLength(255);
            builder.Property(v => v.OrderBy).HasColumnType("Int");
            builder.Property(v => v.IsDefault).HasColumnType("Bit");
            builder.Property(v => v.Disabled).HasColumnType("Bit");
        }
    }

    public class DepartmentTypeModel : BaseTypeIdModel {
        public ICollection<UserModel> Users {
            get; set;
        }
    }
}