using EFCoreDL.DL.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model {
    public class UserData : BaseIDData {
        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }
        public DepartmentTypeData DepartmentType { get; set; }
    }
}