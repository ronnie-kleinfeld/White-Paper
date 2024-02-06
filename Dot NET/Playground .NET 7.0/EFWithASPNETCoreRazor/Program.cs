using EFWithASPNETCoreRazor.Data;
using EFWithASPNETCoreRazor.Services;
using Microsoft.EntityFrameworkCore;

namespace EFWithASPNETCoreRazor {
    public class Program {
        public static void Main(string[] args) {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            //builder.Services.AddTransient // a new instance for each request
            //builder.Services.AddScoped // a new instance for each page
            //builder.Services.AddSingleton // a singleton instance
            builder.Services.AddScoped<IMovieService, MovieService>();

            string? connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
            builder.Services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connectionString));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()) {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}