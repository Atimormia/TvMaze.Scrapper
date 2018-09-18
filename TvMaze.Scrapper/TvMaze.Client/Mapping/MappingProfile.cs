using AutoMapper;
using TvMaze.Client.Contracts.Models;
using TvMaze.Scrapper.Services.Contracts.Models;

namespace TvMaze.Client.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CastModel, TvMazeCast>();
            CreateMap<ShowModel, TvMazeShow>();
        }
    }
}