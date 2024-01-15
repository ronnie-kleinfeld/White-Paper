using EFCoreDL.DL.Model.Base;

namespace EFCoreDL.DL.Model {
    public class DepartmentTypeModel : BaseTypeIDModel {
        public IList<UserModel> Users { get; set; }
    }
}