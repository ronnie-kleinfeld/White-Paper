using Di.Libraries.Services.Product.Models;

namespace Di.Libraries.Services.Product {
    public interface IProductService {
        ProductModel Get(string sku);
    }
}