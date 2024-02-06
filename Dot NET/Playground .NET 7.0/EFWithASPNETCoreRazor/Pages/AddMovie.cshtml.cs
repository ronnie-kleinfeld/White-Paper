using EFWithASPNETCoreRazor.Data;
using EFWithASPNETCoreRazor.Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFWithASPNETCoreRazor.Pages {
    [BindProperties]
    public class AddMovieModel : PageModel {
        public string Title { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }

        private ApplicationDBContext dbContext;

        public AddMovieModel(ApplicationDBContext dbContext) {
            this.dbContext = dbContext;
        }

        public void OnGet() {
            Title = "Welcome";
        }

        public IActionResult OnPost() {
            string value = $"{Title} - {Rate} - {Description}";

            if (!ModelState.IsValid) {
                return Page();
            } else {
                var movie = new Movie() {
                    Title = Title,
                    Rate = Rate,
                    Description = Description
                };
                dbContext.Movies.Add(movie);
                dbContext.SaveChanges();

                return Redirect("Moviews");
            }
        }
    }
}