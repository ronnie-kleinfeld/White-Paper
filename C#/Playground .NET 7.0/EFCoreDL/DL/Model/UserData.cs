using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model {
    public class UserData {
        [Required]
        [MaxLength(255)]
        public string UserName { get; set; }

        [MaxLength(255)]
        public string FirstName { get; set; }

        [MaxLength(255)]
        public string LastName { get; set; }
        public DepartmentTypeData DepartmentType { get; set; }
        public int DepartmentID { get; set; }
    }
}