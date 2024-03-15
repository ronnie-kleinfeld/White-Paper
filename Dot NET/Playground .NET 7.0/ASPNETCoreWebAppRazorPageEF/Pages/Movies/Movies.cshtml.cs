using ASPNETCoreWebAppRazorPageEF.Data.Model;
using ASPNETCoreWebAppRazorPageEF.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPNETCoreWebAppRazorPageEF.Pages {
    [BindProperties]
    public class MoviesModel : PageModel {
        public List<Movie>? Movies { get; set; }

        private IMovieService movieService;

        public MoviesModel(IMovieService movieService) {
            this.movieService = movieService;
        }

        public void OnGet() {
            Movies = movieService.GetMovies();
        }
    }
}