using Microsoft.Extensions.DependencyInjection;
using TvMaze.Client.Contracts;

namespace TvMaze.Client
{
    public class ClientConfigurer
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddScoped<ITvMazeClient, TvMazeClient>();
        }
    }
}