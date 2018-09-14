using System.Collections.Generic;
using TvMaze.Scrapper.Data.Contracts.Repositories;
using TvMaze.Scrapper.Services.Contracts.Models;
using TvMaze.Scrapper.Services.Contracts.Services;

namespace TvMaze.Scrapper.Services
{
    public class ShowInfoService: IShowInfoService
    {
        private readonly IShowInfoRepository _showInfoRepository;

        public ShowInfoService(IShowInfoRepository showInfoRepository)
        {
            _showInfoRepository = showInfoRepository;
        }

        public void AddOrUpdate(ShowModel show)
        {
            throw new System.NotImplementedException();
        }

        public void AddOrUpdate(IEnumerable<ShowModel> shows)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ShowModel> GetAll(int? take, int? page)
        {
            throw new System.NotImplementedException();
        }

        public ShowModel GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Update()
        {
            throw new System.NotImplementedException();
        }
    }
}