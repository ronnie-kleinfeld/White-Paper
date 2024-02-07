using DotNet6.Di.Libraries.Services.Product.Models;
using DotNet6.Di.Libraries.Services.ShoppingCart.Models;

namespace DotNet6.Di.Libraries.Services.ShoppingCart {
    public interface IShoppingCartService {
        ShoppingCartModel Get();
        void AddProduct(ProductModel product, int quantity);
        int Count();
        public bool HasProduct(string sku);
        void SetId(Guid id);
    }
}