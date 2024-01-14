using EFCoreDL.DL.Model.Base;

namespace EFCoreDL.DL.Model {
    public class DepartmentTypeData : BaseTypeIDData {
        public IList<UserData> Users { get; set; }
    }
}