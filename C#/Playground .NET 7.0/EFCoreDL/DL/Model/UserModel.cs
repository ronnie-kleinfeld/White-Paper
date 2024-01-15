using EFCoreDL.DL.Model.Base;
using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model {
    public class UserModel : BaseIDModel {
        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }
        public DepartmentTypeModel DepartmentType { get; set; }
    }
}