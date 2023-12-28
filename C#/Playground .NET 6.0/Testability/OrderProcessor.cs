
namespace Testability
{
    internal class OrderProcessor
    {
        private readonly ShiipingCaululcator _shiipingCaululcator;

        public OrderProcessor()
        {
            _shiipingCaululcator = new ShiipingCaululcator();
        }

        internal void Process(Order order)
        {
            if (order.isShipped)
            {
                throw new InvalidOperationException("This order is already processed.");
            }

            order.Shipment = new Shipment
            {
                Cost = _shiipingCaululcator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}