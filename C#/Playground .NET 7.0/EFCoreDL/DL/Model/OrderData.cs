using EFCoreDL.DL.Model.Base;

namespace EFCoreDL.DL.Model {
    public class OrderData : BaseIDData {
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }

        public CustomerData Customer { get; set; } = null!;
        public IList<OrderDetailData> OrderDetails { get; set; } = null!;
    }
}