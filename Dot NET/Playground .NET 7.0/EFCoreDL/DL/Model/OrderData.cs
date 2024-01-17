using EFCoreDL.DL.Model.Base;

namespace EFCoreDL.DL.Model {
    public class OrderModel : BaseIDModel {
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        public int CustomerId { get; set; }

        public CustomerModel Customer { get; set; } = null!;
        public IList<OrderDetailModel> OrderDetails { get; set; } = null!;
    }
}