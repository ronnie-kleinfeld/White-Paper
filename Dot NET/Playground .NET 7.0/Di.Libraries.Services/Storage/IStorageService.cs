using DotNet6.Di.Libraries.Services.Product.Models;
using DotNet6.Di.Libraries.Services.ShoppingCart.Models;

namespace DotNet6.Di.Libraries.Services.Storage {
    public interface IStorageService {
        IList<ProductModel> Products { get; }
        IList<ShoppingCartModel> ShoppingCarts { get; }
        void AddShoppingCart(Guid id);
    }
}