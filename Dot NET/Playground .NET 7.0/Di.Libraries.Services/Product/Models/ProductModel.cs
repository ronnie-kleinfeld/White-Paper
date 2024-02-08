namespace DotNet6.Di.Libraries.Services.Product.Models {
    public class ProductModel {
        public string Sku { get; }
        public string Name { get; }
        public decimal Price { get; }
        public int Stock { get; protected set; }

        public ProductModel(string sku, string name, decimal price, int stock = 0) {
            Sku = sku;
            Name = name;
            Price = price;
            Stock = stock;
        }

        public void UpdateStock(int stock) {
            Stock = stock;
        }
    }
}