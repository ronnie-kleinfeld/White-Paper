using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model.Base {
    public abstract class BaseData {
        [Required]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}