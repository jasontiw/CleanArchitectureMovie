using CleanArchitectureMovie.Domain;

namespace Infrastructure.Interfaces.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
    }
}
