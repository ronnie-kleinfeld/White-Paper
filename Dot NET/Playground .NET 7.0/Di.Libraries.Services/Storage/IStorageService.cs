using Di.Libraries.Services.Product.Models;
using Di.Libraries.Services.ShoppingCart.Models;

namespace Di.Libraries.Services.Storage {
    public interface IStorageService {
        IList<ProductModel> Products { get; }
        IList<ShoppingCartModel> ShoppingCarts { get; }
        void AddShoppingCart(Guid id);
    }
}