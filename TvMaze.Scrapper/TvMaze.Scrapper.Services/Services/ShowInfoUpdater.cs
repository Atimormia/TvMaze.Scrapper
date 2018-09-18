using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TvMaze.Client.Contracts;
using TvMaze.Scrapper.Data.Contracts.DTOs;
using TvMaze.Scrapper.Data.Contracts.Repositories;
using TvMaze.Scrapper.Services.Contracts.Services;

namespace TvMaze.Scrapper.Services.Services
{
    public class ShowInfoUpdater : IShowInfoUpdater
    {
        private readonly ITvMazeClient _tvMazeClient;
        private readonly IShowInfoRepository _showInfoRepository;
        private readonly IMapper _mapper;

        public ShowInfoUpdater(ITvMazeClient tvMazeClient, IShowInfoRepository showInfoRepository, IMapper mapper)
        {
            _tvMazeClient = tvMazeClient;
            _showInfoRepository = showInfoRepository;
            _mapper = mapper;
        }

        public async Task Update()
        {
            var data = await _tvMazeClient.GetAll();
            await _showInfoRepository.AddOrUpdate(data.Select(x => _mapper.Map<ShowDto>(x)));
        }
    }
}