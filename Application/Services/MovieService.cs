
using Application.Interfaces.Repository;
using CleanArchitectureMovie.Application.Interfaces.Services;
using CleanArchitectureMovie.Domain;

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
