using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TvMaze.Scrapper.Services.Contracts.Models;
using TvMaze.Scrapper.Services.Contracts.Services;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAsync([FromQuery] int take, int page)
        {
            var items = await _showInfoService.GetAll(take, page);

            if (items == null || !items.Any())
            {
                return NotFound();
            }
            return Ok(items);
        }


        //for testing
        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] ShowModel show)
        {
            if (show == null)
            {
                return BadRequest();
            }

            await _showInfoService.AddOrUpdate(show);

            return CreatedAtRoute("GetShow", new { id = show.Id }, show);
        }

        [HttpGet("{id}", Name = "GetShow")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var item = await _showInfoService.GetById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}