using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public async Task AddOrUpdate(ShowModel show)
        {
            await _showInfoRepository.AddOrUpdate(_mapper.Map<ShowDto>(show));
        }

        public async Task AddOrUpdate(IEnumerable<ShowModel> shows)
        {
            await _showInfoRepository.AddOrUpdate(shows.Select(x => _mapper.Map<ShowDto>(x)));
        }

        public async Task<IEnumerable<ShowModel>> GetAll(int take = 0, int page = 0)
        {
            var allShows = await _showInfoRepository.GetAll();
            var allShowModels = allShows.Select(x => _mapper.Map<ShowModel>(x));
            return await Task.FromResult(allShowModels.Skip((page - 1) * take).Take(take));
        }

        public async Task<ShowModel> GetById(int id)
        {
            var show = await _showInfoRepository.GetById(id);
            return await Task.FromResult(_mapper.Map<ShowModel>(show));
        }
        
    }
}