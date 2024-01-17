using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model.Base {
    public abstract class BaseModel {
        [Required]
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}