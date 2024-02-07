using DotNet6.Di.Libraries.Services.Product.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet6.Di.Web.Mvc.Controllers {
    [Route("api/product")]
    [ApiController]
    public class ApiProductController : ControllerBase {
        [HttpGet("stock")]
        public IList<ProductStockModel> GetStock() {
            var productStock = new List<ProductStockModel> {
                new ProductStockModel("BUB-APR", 10),
                new ProductStockModel("BUB-BAS", 14),
                new ProductStockModel("BUB-MUG", 17),
                new ProductStockModel("BUB-TSH", 24)
            };

            return productStock;
        }
    }
}