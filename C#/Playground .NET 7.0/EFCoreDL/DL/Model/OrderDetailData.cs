using EFCoreDL.DL.Model.Base;

namespace EFCoreDL.DL.Model {
    public class OrderDetailData : BaseIDData {
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public OrderData Order { get; set; } = null!;
        public ProductData Product { get; set; } = null!;
    }
}