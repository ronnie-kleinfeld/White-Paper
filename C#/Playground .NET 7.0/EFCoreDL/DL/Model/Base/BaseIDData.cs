using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model.Base {
    public abstract class BaseIDData : BaseData {
        [Key]
        public int ID { get; set; }
    }
}