using System.Collections.Generic;

namespace TvMaze.Scrapper.Data.Contracts.DTOs
{
    public class ShowDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<CastDto> Casts { get; set; }
    }
}