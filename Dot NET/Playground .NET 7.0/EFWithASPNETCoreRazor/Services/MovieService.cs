using EFWithASPNETCoreRazor.Data;
using EFWithASPNETCoreRazor.Data.Model;

namespace EFWithASPNETCoreRazor.Services {
    public class MovieService : IMovieService {
        private ApplicationDBContext dbContext;

        public MovieService(ApplicationDBContext dbContext) {
            this.dbContext = dbContext;
        }

        public void Add(Movie movie) {
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
        }

        public Movie? GetMovie(int id) {
            return dbContext.Movies.FirstOrDefault(x => x.Id == id);
        }

        public List<Movie> GetMovies() {
            return dbContext.Movies.ToList();
        }
    }
}