using System;
using System.Collections.Generic;
using System.Text;

namespace TvMaze.Client.Contracts.Models
{
    public class TvMazeShow
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public IEnumerable<string> Genres{ get; set; }
        public string Status { get; set; }
        public int Runtime { get; set; }
        public DateTime Premiered { get; set; }
        public string OfficialSite { get; set; }
        public Schedule Schedule { get; set; }
        public Rating Rating { get; set; }
        public int Waight { get; set; }
        public TvNetwork Network { get; set; }
        public ShowExternals Externals { get; set; }
        public Image Image { get; set; }
        public string Summary { get; set; }
        public string Updated { get; set; }
        public Links Links { get; set; }
        public IEnumerable<TvMazeCast> Casts { get; set; }
    }
}
