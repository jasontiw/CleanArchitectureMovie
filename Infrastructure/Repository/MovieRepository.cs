using CleanArchitectureMovie.Domain;
using Infrastructure.Interfaces.Repository;

namespace Infrastructure.Repository
{
    public class MovieRepository : IMovieRepository
    {
        public List<Movie> GetAll()
        {
            return new List<Movie>() { new Movie() { Id = 1, Title = "Movie 1" } };
        }
    }
}
