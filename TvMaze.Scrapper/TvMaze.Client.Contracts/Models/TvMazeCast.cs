namespace TvMaze.Client.Contracts.Models
{
    public class TvMazeCast
    {
        public Person Person { get; set; }
        public Character Caracter { get; set; }
        public bool Self { get; set; }
        public bool Voice { get; set; }
    }
}