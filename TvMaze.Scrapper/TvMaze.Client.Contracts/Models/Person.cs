using System;

namespace TvMaze.Client.Contracts.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime? Deathday { get; set; }
        public string Gender { get; set; }
        public Image Image { get; set; }
        public Links Links { get; set; }
    }
}
