using EFCoreDL.DL.Model.Base;

namespace EFCoreDL.DL.Model {
    public class DepartmentTypeData : BaseTypeIDData {
        public ICollection<UserData> Users { get; set; }
    }
}