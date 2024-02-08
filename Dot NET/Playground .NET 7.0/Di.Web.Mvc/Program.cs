using Di.Libraries.Services.Product;
using Di.Libraries.Services.ShoppingCart;
using Di.Libraries.Services.Storage;

namespace Di.Web.Mvc {
    internal class Program {
        private static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add dependency injection.
            builder.Services.AddSingleton<IStorageService, StorageService>();
            builder.Services.AddScoped<IShoppingCartService, ShoppingCartService>(
                (serviceProvider) => {
                    return new ShoppingCartService(serviceProvider.GetRequiredService<IStorageService>());
                }
                );
            builder.Services.AddTransient<IProductService, ProductService>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}