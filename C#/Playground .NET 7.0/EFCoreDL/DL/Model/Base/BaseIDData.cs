using System.ComponentModel.DataAnnotations;

namespace EFCoreDL.DL.Model.Base {
    public class BaseIDData : BaseData {
        [Key]
        public int ID { get; set; }
    }
}