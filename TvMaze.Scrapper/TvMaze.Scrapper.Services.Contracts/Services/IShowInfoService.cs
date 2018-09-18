using System.Collections.Generic;
using System.Threading.Tasks;
using TvMaze.Scrapper.Services.Contracts.Models;

namespace TvMaze.Scrapper.Services.Contracts.Services
{
    public interface IShowInfoService
    {
        //for testing
        Task AddOrUpdate(ShowModel show);
        Task AddOrUpdate(IEnumerable<ShowModel> shows);

        //for prod
        Task<IEnumerable<ShowModel>> GetAll(int take, int page);
        Task<ShowModel> GetById(int id);
    }
}