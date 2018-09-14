using AutoMapper;
using TvMaze.Scrapper.Data.Contracts.DTOs;
using TvMaze.Scrapper.Data.Entities;

namespace TvMaze.Scrapper.Data.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Cast, CastDto>();
            CreateMap<Show, ShowDto>();
        }

    }
}