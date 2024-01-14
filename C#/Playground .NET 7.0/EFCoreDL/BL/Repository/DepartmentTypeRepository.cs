using EFCoreDL.BL.Repository.Base;
using EFCoreDL.DL.Context;
using EFCoreDL.DL.Model;

namespace EFCoreDL.BL.Repository {
    public interface IDepartmentTypeRepository : IRepository<DepartmentTypeData> {
    }
    public class DepartmentTypeRepository : BaseRepository<DepartmentTypeData>, IDepartmentTypeRepository {
        public DepartmentTypeRepository(DLContext context) : base(context) {
        }
    }
}