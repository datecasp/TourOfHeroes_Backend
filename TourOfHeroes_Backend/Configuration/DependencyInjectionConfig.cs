using TourOfHeroes_Backend.DataContext;
using TourOfHeroes_Backend.Models;
using TourOfHeroes_Backend.Repositories;
using TourOfHeroes_Backend.Services;

namespace TourOfHeroes_Backend.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<Context>();

            services.AddScoped<IHeroService, HeroService>();
            services.AddScoped<IHeroRepository, HeroRepository>();

            return services;
        }
    }
}
