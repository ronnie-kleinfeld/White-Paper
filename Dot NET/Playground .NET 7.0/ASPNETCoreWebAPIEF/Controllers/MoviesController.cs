using ASPNETCoreWebAPIEF.Data;
using ASPNETCoreWebAPIEF.Data.Model;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWebAPIEF.Controllers {
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase {
        private ApplicationDBContext dbContext;
        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ApplicationDBContext dbContext, ILogger<MoviesController> logger) {
            this.dbContext = dbContext;
            _logger = logger;
        }

        [HttpGet]
        public List<Movie> Index() {
            return dbContext.Movies.ToList();
        }

        [HttpPost]
        public Movie Post(string title, string description, int rate) {
            Movie movie = new Movie() {
                Title = title,
                Description = description,
                Rate = rate
            };

            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();

            return movie;
        }

        [HttpPut]
        public IActionResult Put(int id, string title, string description, int rate) {
            Movie? movie = dbContext.Movies.FirstOrDefault<Movie>(m => m.Id == id);

            if (movie == null) {
                return NotFound();
            } else {
                movie.Title = title;
                movie.Description = description;
                movie.Rate = rate;

                dbContext.Movies.Add(movie);
                dbContext.SaveChanges();

                return Ok(movie);
            };
        }

        [HttpDelete]
        public IActionResult Delete(int id) {
            Movie? movie = dbContext.Movies.FirstOrDefault<Movie>(m => m.Id == id);

            if (movie == null) {
                _logger.LogInformation($"Movie id {id} not found.");
                return NotFound();
            } else {
                dbContext.Movies.Remove(movie);
                dbContext.SaveChanges();

                _logger.LogInformation($"Movie id {id} deleted.");
                return Ok();
            }
        }
    }
}