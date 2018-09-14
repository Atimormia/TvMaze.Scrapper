using System.Collections.Generic;

namespace TvMaze.Scrapper.Services.Contracts.Models
{
    public class ShowModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<CastModel> Casts { get; set; }
    }
}