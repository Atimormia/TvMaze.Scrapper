using System;

namespace TvMaze.Scrapper.Data.Entities
{
    public class Cast
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? BirthDay { get; set; }
        //public Show Show { get; set; }
    }
}