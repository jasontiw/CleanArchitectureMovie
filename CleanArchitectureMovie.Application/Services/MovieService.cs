
using CleanArchitectureMovie.Application.Interfaces.Services;
using CleanArchitectureMovie.Domain;
using Infrastructure.Interfaces.Repository;

namespace CleanArchitectureMovie.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly IMovieRepository _movieRepository;
        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }
    }
}
