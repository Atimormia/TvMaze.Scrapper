using Microsoft.AspNetCore.Mvc;

namespace TvMaze.Scrapper.API.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        /// <summary>
        /// Initiates TvMaze data retrieving
        /// </summary>
        /// <returns></returns>
        [HttpGet("update")]
        public string Update()
        {
            return "Done";
        }
    }
}