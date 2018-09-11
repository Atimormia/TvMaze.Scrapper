using Microsoft.AspNetCore.Mvc;

namespace TvMaze.Scrapper.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ShowsController : Controller
    {
        /// <summary>
        /// Scrapes the TVMaze API for show and cast information
        /// </summary>
        /// <param name="take">Items for page</param>
        /// <param name="page">Page number</param>
        /// <returns>A list of shows with information</returns>
        [HttpGet]
        public IActionResult Get([FromQuery] int take, int page)
        {
            return Ok("Scrapper Api - Database was updated");
        }
    }
}