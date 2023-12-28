
namespace Testability
{
    internal class ShiipingCaululcator
    {
        internal object CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }

            return 0;
        }
    }
}