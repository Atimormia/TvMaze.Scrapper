using System.Collections.Generic;
using System.Threading.Tasks;
using TvMaze.Scrapper.Services.Contracts.Models;

namespace TvMaze.Scrapper.Services.Contracts
{
    public interface ITvMazeClient
    {
        Task<IEnumerable<ShowModel>> GetAll();
    }
}