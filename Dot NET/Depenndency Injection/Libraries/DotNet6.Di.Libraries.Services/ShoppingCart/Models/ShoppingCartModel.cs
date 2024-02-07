using DotNet6.Di.Libraries.Services.Product.Models;

namespace DotNet6.Di.Libraries.Services.ShoppingCart.Models {
    public class ShoppingCartModel {
        public Guid Id { get; }
        public IList<ShoppingCartItemModel> Items { get; }

        public ShoppingCartModel(Guid id) {
            Id = id;
            Items = new List<ShoppingCartItemModel>();
        }

        public void AddUpdateItem(ProductModel product, int quantity) {
            var item = Items.FirstOrDefault(item => item.Product == product);

            if (item == null) {
                Items.Add(new ShoppingCartItemModel(product, quantity));
            } else {
                item.UpdateQuantity(product, quantity);
            }
        }
    }
}