using Microsoft.Extensions.DependencyInjection;
using MovieStore.BL.Interfaces;
using MovieStore.BL.Services;
using MovieStore.DL.Interfaces;
using MovieStore.DL.Repositories;

namespace MovieStore.BL
{
    public static class DependencyInjection
    {
        /// <summary>
        /// Регистрира зависимостите за бизнес логиката (Business Layer).
        /// </summary>
        public static IServiceCollection RegisterBusinessLayer(this IServiceCollection services)
        {
            // Пример за регистриране на услугите в бизнес слоя
            services.AddSingleton<IMovieService, MovieService>();

            return services;
        }

        /// <summary>
        /// Регистрира зависимостите за слоя с данни (Data Layer).
        /// </summary>
        public static IServiceCollection RegisterDataLayer(this IServiceCollection services)
        {
            // Пример за регистриране на репозиториите
            services.AddSingleton<IMovieRepository, MovieRepository>();

            return services;
        }
    }
}

