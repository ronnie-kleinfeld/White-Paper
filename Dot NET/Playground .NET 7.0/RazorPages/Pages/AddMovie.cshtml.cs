using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages {
    [BindProperties]
    public class AddMovieModel : PageModel {
        //[BindProperty]
        public string Title { get; set; }
        //[BindProperty]
        public string Rate { get; set; }
        //[BindProperty]
        public string Description { get; set; }

        public void OnGet() {
            Title = "Welcome";
        }

        public IActionResult OnPost() {
            string value = $"{Title} - {Rate} - {Description}";

            return Page();
            return Redirect("Moviews");
        }
    }
}