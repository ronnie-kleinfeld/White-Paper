using EFWithASPNETCoreRazor.Data.Model;

namespace EFWithASPNETCoreRazor.Services {
    public interface IMovieService {
        List<Movie> GetMovies();
        Movie? GetMovie(int id);
        void Add(Movie movie);
    }
}