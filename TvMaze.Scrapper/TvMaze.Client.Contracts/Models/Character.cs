using System;

namespace TvMaze.Client.Contracts.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public Image Image { get; set; }
        public Links Links { get; set; }
    }
}