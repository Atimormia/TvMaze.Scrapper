using System.Collections.Generic;
using TvMaze.Scrapper.Data.Contracts.DTOs;

namespace TvMaze.Scrapper.Data.Contracts.Repositories
{
    public interface IShowInfoRepository
    {
        void AddOrUpdate(ShowDto show);
        void AddOrUpdate(IEnumerable<ShowDto> shows);
        IEnumerable<ShowDto> GetAll();
        ShowDto GetById(int id);
    }
}
