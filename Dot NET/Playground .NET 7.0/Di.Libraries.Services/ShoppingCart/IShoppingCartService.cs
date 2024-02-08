using Di.Libraries.Services.Product.Models;
using Di.Libraries.Services.ShoppingCart.Models;

namespace Di.Libraries.Services.ShoppingCart {
    public interface IShoppingCartService {
        ShoppingCartModel Get();
        void AddProduct(ProductModel product, int quantity);
        int Count();
        public bool HasProduct(string sku);
        void SetId(Guid id);
    }
}