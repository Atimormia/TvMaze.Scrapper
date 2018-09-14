using System;

namespace TvMaze.Scrapper.Data.Contracts.DTOs
{
    public class CastDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}