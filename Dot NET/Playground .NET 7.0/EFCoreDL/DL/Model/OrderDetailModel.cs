using EFCoreDL.DL.Model.Base;

namespace EFCoreDL.DL.Model {
    public class OrderDetailModel : BaseIDModel {
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public OrderData Order { get; set; } = null!;
        public ProductModel Product { get; set; } = null!;
    }
}