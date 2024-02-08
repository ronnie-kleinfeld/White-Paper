using Di.Libraries.Services.Product.Models;

namespace Di.Libraries.Services.ShoppingCart.Models {
    public class ShoppingCartItemModel {
        public ProductModel Product { get; }
        public decimal Price { get; protected set; }
        public int Quantity { get; protected set; }

        public ShoppingCartItemModel(ProductModel product, int quantity) {
            Product = product;
            Price = product.Price;
            Quantity = quantity;
        }

        public void UpdateQuantity(ProductModel product, int quantity) {
            Price = product.Price;
            Quantity = quantity;
        }
    }
}