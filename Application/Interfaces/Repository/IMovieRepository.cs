using CleanArchitectureMovie.Domain;

namespace Application.Interfaces.Repository
{
    public interface IMovieRepository
    {
        List<Movie> GetAll();
    }
}
