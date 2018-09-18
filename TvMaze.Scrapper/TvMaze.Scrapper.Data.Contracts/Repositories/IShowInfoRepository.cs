using System.Collections.Generic;
using System.Threading.Tasks;
using TvMaze.Scrapper.Data.Contracts.DTOs;

namespace TvMaze.Scrapper.Data.Contracts.Repositories
{
    public interface IShowInfoRepository
    {
        Task AddOrUpdate(ShowDto show);
        Task AddOrUpdate(IEnumerable<ShowDto> shows);
        Task<IEnumerable<ShowDto>> GetAll();
        Task<ShowDto> GetById(int id);
    }
}
