using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TvMaze.Scrapper.Data
{
    public static class Configurer
    {
        public static void Configure(IServiceCollection services, IConfigurationRoot config)
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Production")
                services.AddDbContext<ScrapperDbContext>(options =>
                    options.UseSqlServer(config.GetConnectionString("ScrapperDbConnection")));
            else
                services.AddDbContext<ScrapperDbContext>(options =>
                    options.UseSqlite("Data Source=Scrapper.db"));
        }
    }
}