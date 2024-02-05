using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data.Model;

namespace RazorPages.Pages {
    public class MoviesModel : PageModel {
        public List<Movie> Movies { get; set; }

        public void OnGet() {
            Movies = new List<Movie>() {
                new Movie() {
                    Id = 1,
                    Title = "Test",
                    Rate = 100,
                    Description = "Test"
                },
                new Movie() {
                    Id = 2,
                    Title = "Test 2",
                    Rate = 99,
                    Description = "Test 2"
                }
            };
        }
    }
}