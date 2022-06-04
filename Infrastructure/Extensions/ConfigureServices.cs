using Application.Interfaces.Repository;
using CleanArchitectureMovie.Application.Interfaces.Services;
using CleanArchitectureMovie.Application.Services;
using Infrastructure.Repository;

using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions;

public static class ConfigureServices
{
    public static IServiceCollection ConfigureInfrastructure(this IServiceCollection services)
    {
        // Add framework services.
        services.AddScoped<IMovieService, MovieService>();
        services.AddScoped<IMovieRepository, MovieRepository>();
        return services;
    }
}


