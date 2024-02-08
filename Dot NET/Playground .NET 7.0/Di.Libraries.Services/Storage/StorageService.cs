using Di.Libraries.Services.Product.Models;
using Di.Libraries.Services.ShoppingCart.Models;

namespace Di.Libraries.Services.Storage {
    public class StorageService : IStorageService {
        public IList<ProductModel> Products { get; private set; }
        public IList<ShoppingCartModel> ShoppingCarts { get; private set; }

        public StorageService() {
            Products = new List<ProductModel>();
            ShoppingCarts = new List<ShoppingCartModel>();

            AddProduct(new ProductModel("BUB-APR", "A Gumball for Your Thoughts Apron", 24, 4));
            AddProduct(new ProductModel("BUB-BAS", "A Gumball for Your Thoughts Baseball Hat", 29, 2));
            AddProduct(new ProductModel("BUB-MUG", "A Gumball for Your Thoughts Mug", 16, 6));
            AddProduct(new ProductModel("BUB-TSH", "A Gumball for Your Thoughts T-shirt", 26, 10));
        }

        private void AddProduct(ProductModel productModel) {
            if (!Products.Any(p => p.Sku == productModel.Sku)) {
                Products.Add(productModel);
            }
        }

        public void AddShoppingCart(Guid id) {
            if (!ShoppingCarts.Any(sc => sc.Id == id)) {
                ShoppingCarts.Add(new ShoppingCartModel(id));
            }
        }
    }
}