using Di.Libraries.Services.Product.Models;
using Di.Libraries.Services.Storage;

namespace Di.Libraries.Services.Product {
    public class ProductService : IProductService {
        private readonly IStorageService _storageService;

        public ProductService(IStorageService storageService) {
            _storageService = storageService;
        }

        public ProductModel Get(string sku) {
            return _storageService.Products.FirstOrDefault(p => p.Sku == sku);
        }
    }
}