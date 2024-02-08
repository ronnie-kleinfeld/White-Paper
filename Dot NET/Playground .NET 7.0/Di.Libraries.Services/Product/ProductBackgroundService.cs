using Di.Libraries.Services.Product.Models;
using Di.Libraries.Services.Storage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Di.Libraries.Services.Product {
    public class ProductBackgroundService : IHostedService {
        private readonly IServiceProvider _serviceProvider;
        private readonly IStorageService _storageService;
        private readonly ILogger _logger;

        public ProductBackgroundService(IServiceProvider serviceProvier, IStorageService storageService, ILogger<ProductBackgroundService> logger) {
            _serviceProvider = serviceProvier;
            _storageService = storageService;
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken) {
            Task.Run(async () => {
                await Task.Delay(new TimeSpan(0, 0, 5));

                while (!cancellationToken.IsCancellationRequested) {
                    using (var scope = _serviceProvider.CreateScope()) {
                        var productService = scope.ServiceProvider.GetService<IProductService>();

                        var httpClient = new HttpClient();
                        var httpResponse = await httpClient.GetAsync("https://localhost:8001/api/product/stock");

                        if (httpResponse.IsSuccessStatusCode) {
                            _logger.LogInformation("Product stocks received.");

                            var productStocks = JsonConvert.DeserializeObject<IList<ProductStockModel>>(await httpResponse.Content.ReadAsStringAsync());

                            foreach (var productStock in productStocks) {
                                var product = productService.Get(productStock.Sku);

                                if (product != null) {
                                    product.UpdateStock(productStock.Stock);
                                    _logger.LogInformation("Product stock '{0}' updated to '{1}'.", productStock.Sku, productStock.Stock);
                                }
                            }
                        } else {
                            _logger.LogWarning("Not a valid response from the HTTP client. Unable to get stocks.");
                        }
                    }

                    await Task.Delay(new TimeSpan(0, 1, 0));
                }
            });

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken) {
            return Task.CompletedTask;
        }
    }
}