using System.Linq;
using AutoMapper;
using TvMaze.Scrapper.Data.Contracts.DTOs;
using TvMaze.Scrapper.Data.Contracts.Repositories;
using TvMaze.Scrapper.Services.Contracts;
using TvMaze.Scrapper.Services.Contracts.Services;

namespace TvMaze.Scrapper.Services
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

        public void Update()
        {
            _showInfoRepository.AddOrUpdate(_tvMazeClient.GetAll().Select(x => _mapper.Map<ShowDto>(x)));
        }
    }
}