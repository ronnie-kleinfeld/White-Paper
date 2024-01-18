using DLEF.Context;
using DLEF.Handlers.Base.Data;
using DLEF.Handlers.Base.Map;
using DLEF.Handlers.Base.Repository;
using System.Collections.Generic;

namespace DLEF.Handlers
{
    public interface IDepartmentTypeRepository : IRepository<DepartmentTypeData>
    {
    }
    public class DepartmentTypeRepository : Repository<DepartmentTypeData>, IDepartmentTypeRepository
    {
        public DepartmentTypeRepository(DLContext context) : base(context)
        {
        }
    }

    internal class DepartmentTypeIDMap : BaseTypeIDMap<DepartmentTypeData>
    {
        public DepartmentTypeIDMap() : base("Departments")
        {
            Property(v => v.Name).IsRequired().HasMaxLength(255);
            Property(v => v.Description).IsRequired().HasMaxLength(255);
            Property(v => v.OrderBy).HasColumnType("Int");
            Property(v => v.IsDefault).HasColumnType("Bit");
            Property(v => v.Disabled).HasColumnType("Bit");
        }
    }

    public class DepartmentTypeData : BaseTypeIDData
    {
        public ICollection<UserData> Users { get; set; }
    }
}