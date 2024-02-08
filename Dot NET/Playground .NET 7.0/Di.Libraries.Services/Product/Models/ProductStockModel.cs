namespace DotNet6.Di.Libraries.Services.Product.Models {
    public class ProductStockModel {
        public string Sku { get; }
        public int Stock { get; }

        public ProductStockModel(string sku, int stock) {
            Sku = sku;
            Stock = stock;
        }
    }
}