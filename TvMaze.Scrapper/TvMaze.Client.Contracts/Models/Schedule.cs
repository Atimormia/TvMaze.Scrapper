using System;

namespace TvMaze.Client.Contracts.Models
{
    public class Schedule
    {
        public string Time { get; set; }
        public DayOfWeek Day { get; set; }
    }
}