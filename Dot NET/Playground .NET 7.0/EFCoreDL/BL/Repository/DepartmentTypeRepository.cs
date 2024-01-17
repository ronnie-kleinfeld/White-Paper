using EFCoreDL.BL.Repository.Base;
using EFCoreDL.DL.Context;
using EFCoreDL.DL.Model;

namespace EFCoreDL.BL.Repository {
    public interface IDepartmentTypeRepository : IRepository<DepartmentTypeModel> {
    }
    public class DepartmentTypeRepository : BaseRepository<DepartmentTypeModel>, IDepartmentTypeRepository {
        public DepartmentTypeRepository(DLContext context) : base(context) {
        }
    }
}