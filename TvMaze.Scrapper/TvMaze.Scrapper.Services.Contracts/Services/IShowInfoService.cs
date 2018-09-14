using System.Collections.Generic;
using TvMaze.Scrapper.Services.Contracts.Models;

namespace TvMaze.Scrapper.Services.Contracts.Services
{
    public interface IShowInfoService
    {
        //for testing
        void AddOrUpdate(ShowModel show);
        void AddOrUpdate(IEnumerable<ShowModel> shows);

        //for prod
        IEnumerable<ShowModel> GetAll(int? take, int? page);
        ShowModel GetById(int id);
        bool Update();
    }
}