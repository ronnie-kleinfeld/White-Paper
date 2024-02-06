using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Data.Model;

namespace RazorPages.Pages {
    [BindProperties]
    public class MovieModel : PageModel {
        public Movie Movie { get; set; }

        public void OnGet(int id) {
            Movie = new Movie() {
                Id = id,
                Title = "Title " + id,
                Rate = 100 - id,
                Description = "Description " + id
            };
        }
    }
}