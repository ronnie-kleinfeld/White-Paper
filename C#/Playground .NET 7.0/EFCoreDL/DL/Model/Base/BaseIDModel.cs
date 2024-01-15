using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model.Base {
    public abstract class BaseIDModel : BaseModel {
        [Key]
        public int ID { get; set; }
    }
}