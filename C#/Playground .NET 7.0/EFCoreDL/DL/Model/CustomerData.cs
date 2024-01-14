using EFCoreDL.DL.Model.Base;

namespace EFCoreDL.DL.Model {
    public class CustomerData : BaseIDData {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }

        public IList<OrderData> Orders { get; set; } = null!;
    }
}