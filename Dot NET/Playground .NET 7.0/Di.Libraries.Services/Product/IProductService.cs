using DotNet6.Di.Libraries.Services.Product.Models;

namespace DotNet6.Di.Libraries.Services.Product {
    public interface IProductService {
        ProductModel Get(string sku);
    }
}