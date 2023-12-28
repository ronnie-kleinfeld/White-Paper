
namespace Testability
{
    internal class Order
    {
        internal bool isShipped;

        public DateTime DatePlaced { get; set; }
        public float TotalPrice { get; set; }
        public Shipment Shipment { get; internal set; }
    }
}