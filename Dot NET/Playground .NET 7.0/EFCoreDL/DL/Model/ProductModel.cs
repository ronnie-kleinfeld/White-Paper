using EFCoreDL.DL.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreDL.DL.Model {
    public class ProductModel : BaseIDModel {
        public string Name { get; set; } = null!;

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
    }
}