using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model.Base {
    public class BaseData {
        [Required]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}