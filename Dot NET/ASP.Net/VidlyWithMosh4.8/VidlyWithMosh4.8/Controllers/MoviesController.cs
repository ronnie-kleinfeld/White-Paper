using System.Web.Mvc;
using VidlyWithMosh4._8.Models;

namespace VidlyWithMosh4._8.Controllers {
    public class MoviesController : Controller {
        // Get; Movies/Random
        public ActionResult Random() {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }

        // Get; Movies/Random
        [Route("movies/GetByReleaseYearMonth/{year}/{month}")]
        public ActionResult GetByReleaseYearMonth(int year, int month) {
            var movie = new Movie() { Name = $"Shrek!{year}/{month}" };

            ViewData["Movie"] = movie;
            return View();
        }
    }
}