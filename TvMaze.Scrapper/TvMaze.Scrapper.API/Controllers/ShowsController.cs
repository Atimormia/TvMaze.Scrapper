using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TvMaze.Scrapper.Data;
using TvMaze.Scrapper.Data.Entities;

namespace TvMaze.Scrapper.API.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class ShowsController : Controller
    {
        private readonly ScrapperDbContext _context;
        public ShowsController(ScrapperDbContext context)
        {
            _context = context;

            if (!_context.Shows.Any())
            {
                _context.Shows.Add(new Show() { Id = 1, Name = "Item1" });
                _context.SaveChanges();
            }
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
            return Ok("Scrapper Api - Database was updated");
        }

        [HttpPost]
        public IActionResult Add([FromBody] Show show)
        {
            if (show == null)
            {
                return BadRequest();
            }

            _context.Shows.Add(show);

            return CreatedAtRoute("GetShow", new { id = show.Id }, show);
        }

        [HttpGet("{id}", Name = "GetShow")]
        public IActionResult GetById(int id)
        {
            var item = _context.Shows.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}