using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TvMaze.Scrapper.Services.Contracts.Services;

namespace TvMaze.Scrapper.Services
{
    public static class ServicesConfigurer
    {
        public static void Configure(IServiceCollection services)
        {
            //services.AddAutoMapper();
            services.AddScoped<IShowInfoService, ShowInfoService>();
            services.AddScoped<IShowInfoUpdater, ShowInfoUpdater>();

        }
    }
}