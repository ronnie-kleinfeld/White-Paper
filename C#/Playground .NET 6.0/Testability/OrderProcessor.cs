
namespace Testability
{
    public class OrderProcessor
    {
        private readonly IShiipingCalculator _shiipingCaululcator;

        public OrderProcessor(IShiipingCalculator shiipingCalculator)
        {
            _shiipingCaululcator = shiipingCalculator;
        }

        public void Process(Order order)
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