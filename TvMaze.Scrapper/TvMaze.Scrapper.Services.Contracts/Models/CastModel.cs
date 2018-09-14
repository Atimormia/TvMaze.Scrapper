using System;

namespace TvMaze.Scrapper.Services.Contracts.Models
{
    public class CastModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDay { get; set; }
    }
}