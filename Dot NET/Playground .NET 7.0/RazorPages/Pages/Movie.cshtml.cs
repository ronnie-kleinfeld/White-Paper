using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data.Model;

namespace RazorPages.Pages {
    [BindProperties]
    public class MovieModel : PageModel {
        public Movie Movie { get; set; }

        //[Route({id})]
        public void OnGet(int id) {
            Movie = new Movie() {
                Id = 1,
                Title = "Test",
                Rate = 100,
                Description = "Test"
            };
        }
    }
}