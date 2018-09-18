using System.Collections.Generic;
using TvMaze.Scrapper.Services.Contracts.Models;

namespace TvMaze.Scrapper.Services.Contracts
{
    public interface ITvMazeClient
    {
        IEnumerable<ShowModel> GetAll();
    }
}