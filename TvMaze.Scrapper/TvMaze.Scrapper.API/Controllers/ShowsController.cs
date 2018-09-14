using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TvMaze.Scrapper.Services.Contracts.Models;
using TvMaze.Scrapper.Services.Contracts.Services;

namespace TvMaze.Scrapper.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ShowsController : Controller
    {
        private readonly IShowInfoService _showInfoService;
        public ShowsController(IShowInfoService showInfoService)
        {
            _showInfoService = showInfoService;
        }
        /// <summary>
        /// Scrapes the TVMaze API for show and cast information
        /// </summary>
        /// <param name="take">Items for page</param>
        /// <param name="page">Page number</param>
        /// <returns>A list of shows with information</returns>
        [HttpGet]
        public IActionResult Get([FromQuery] int take, int page)
        {
            var items = _showInfoService.GetAll(take, page);

            if (items == null || !items.Any())
            {
                return NotFound();
            }
            return Ok(items);
        }


        //for testing
        [HttpPost]
        public IActionResult Add([FromBody] ShowModel show)
        {
            if (show == null)
            {
                return BadRequest();
            }

            _showInfoService.AddOrUpdate(show);

            return CreatedAtRoute("GetShow", new { id = show.Id }, show);
        }

        [HttpGet("{id}", Name = "GetShow")]
        public IActionResult GetById(int id)
        {
            var item = _showInfoService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}