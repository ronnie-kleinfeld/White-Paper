using ASPNETCoreWebAppRazorPageEF.Data.Model;
using ASPNETCoreWebAppRazorPageEF.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreWebAppRazorPageEF.Pages {
    [BindProperties]
    public class AddMovieModel : PageModel {
        public string Title { get; set; }
        public int Rate { get; set; }
        public string Description { get; set; }

        private IMovieService movieService;

        public AddMovieModel(IMovieService movieService) {
            this.movieService = movieService;
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
                movieService.Add(movie);

                return Page();
            }
        }
    }
}