using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using TvMaze.Scrapper.Data.Contracts.DTOs;
using TvMaze.Scrapper.Data.Contracts.Repositories;
using TvMaze.Scrapper.Services.Contracts.Models;
using TvMaze.Scrapper.Services.Contracts.Services;

namespace TvMaze.Scrapper.Services
{
    public class ShowInfoService: IShowInfoService
    {
        private readonly IShowInfoRepository _showInfoRepository;
        private readonly IMapper _mapper;

        public ShowInfoService(IShowInfoRepository showInfoRepository, IMapper mapper)
        {
            _showInfoRepository = showInfoRepository;
            _mapper = mapper;
        }

        public void AddOrUpdate(ShowModel show)
        {
            _showInfoRepository.AddOrUpdate(_mapper.Map<ShowDto>(show));
        }

        public void AddOrUpdate(IEnumerable<ShowModel> shows)
        {
            _showInfoRepository.AddOrUpdate(shows.Select(x => _mapper.Map<ShowDto>(x)));
        }

        public IEnumerable<ShowModel> GetAll(int? take, int? page)
        {
            var allShows = _showInfoRepository.GetAll().Select(x => _mapper.Map<ShowModel>(x));
            if (take.HasValue && page.HasValue)
            {
                return allShows.Skip((page.Value - 1) * take.Value).Take(take.Value);
            }
            return allShows;
        }

        public ShowModel GetById(int id)
        {
            return _mapper.Map<ShowModel>(_showInfoRepository.GetById(id));
        }
        
    }
}