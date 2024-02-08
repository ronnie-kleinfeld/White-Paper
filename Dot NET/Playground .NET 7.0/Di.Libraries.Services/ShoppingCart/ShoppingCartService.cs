using DotNet6.Di.Libraries.Services.Product;
using DotNet6.Di.Libraries.Services.Product.Models;
using DotNet6.Di.Libraries.Services.ShoppingCart.Models;
using DotNet6.Di.Libraries.Services.Storage;

namespace DotNet6.Di.Libraries.Services.ShoppingCart {
    public class ShoppingCartService : IShoppingCartService {
        private readonly IProductService _productService;
        private readonly IStorageService _storageService;
        private Guid? Id { get; set; }

        public ShoppingCartService(IProductService productService) {
            _productService = productService;
        }
        public ShoppingCartService(IStorageService storageService) {
            _storageService = storageService;
        }

        public ShoppingCartModel Get() {
            if (!Id.HasValue) {
                throw new Exception("The Id for the shopping cart has not been set.");
            }

            return _storageService.ShoppingCarts.First(sc => sc.Id == Id.Value);
        }

        public void AddProduct(ProductModel product, int quantity) {
            Get().Items.Add(new ShoppingCartItemModel(product, quantity));
        }

        public int Count() {
            return Get().Items.Count();
        }

        public bool HasProduct(string sku) {
            return Get().Items.Any(i => i.Product.Sku == sku);
        }

        public void SetId(Guid id) {
            Id = id;
            _storageService.AddShoppingCart(id);
        }
    }
}