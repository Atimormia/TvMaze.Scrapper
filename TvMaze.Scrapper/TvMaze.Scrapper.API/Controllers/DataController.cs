using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using TvMaze.Scrapper.Services.Contracts.Services;

namespace TvMaze.Scrapper.API.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly IShowInfoService _showInfoService;

        public DataController(IShowInfoService showInfoService)
        {
            _showInfoService = showInfoService;
        }

        /// <summary>
        /// Initiates TvMaze data retrieving
        /// </summary>
        /// <returns></returns>
        [HttpGet("update")]
        public IActionResult Update()
        {
            var result = _showInfoService.Update();
            if (result)
            {
                return Ok("Scrapper Api - Database was updated");
            }

            return StatusCode(500);
        }
    }
}