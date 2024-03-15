using ASPNETCoreWebAppRazorPageEF.Data.Model;

namespace ASPNETCoreWebAppRazorPageEF.Services {
    public interface IMovieService {
        List<Movie> GetMovies();
        Movie? GetMovie(int id);
        void Add(Movie movie);
    }
}