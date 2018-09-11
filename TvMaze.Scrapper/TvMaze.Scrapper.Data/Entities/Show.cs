using System.Collections.Generic;

namespace TvMaze.Scrapper.Data.Entities
{
    public class Show
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Cast> Casts { get; set; }
    }
}