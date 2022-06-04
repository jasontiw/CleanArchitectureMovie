using CleanArchitectureMovie.Domain;

namespace CleanArchitectureMovie.Application.Interfaces.Services;

public interface IMovieService
{
    List<Movie> GetAll();
}
