

using Application.Interfaces.Repository;
using CleanArchitectureMovie.Application.Interfaces.Services;
using CleanArchitectureMovie.Application.Services;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Api
{
    public static class Configuration
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
            services.AddScoped<IMovieRepository, MovieRepository>();
            return services;

        }
    }
}
