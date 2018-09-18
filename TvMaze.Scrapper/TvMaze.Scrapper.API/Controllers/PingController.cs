using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TvMaze.Scrapper.API.Controllers
{
    [Route("api/[controller]")]
    public class PingController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Scrapper Api - Running");
        }
    }
}
