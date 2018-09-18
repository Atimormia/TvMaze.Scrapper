using AutoMapper;
using TvMaze.Scrapper.Data.Contracts.DTOs;
using TvMaze.Scrapper.Services.Contracts.Models;

namespace TvMaze.Scrapper.Services.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CastModel, CastDto>();
            CreateMap<ShowModel, ShowDto>();
        }

    }
}