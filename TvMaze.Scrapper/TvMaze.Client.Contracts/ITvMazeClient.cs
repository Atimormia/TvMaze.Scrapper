using System.Collections.Generic;
using System.Threading.Tasks;
using TvMaze.Client.Contracts.Models;

namespace TvMaze.Client.Contracts
{
    public interface ITvMazeClient
    {
        Task<IEnumerable<TvMazeShow>> GetAll();
    }
}