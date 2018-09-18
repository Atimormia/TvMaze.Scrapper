using System;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using TvMaze.Scrapper.Services.Contracts.Services;
using System.Threading.Tasks;

namespace TvMaze.Scrapper.API.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        private readonly IShowInfoUpdater _showInfoUpdater;

        public DataController(IShowInfoUpdater showInfoUpdater)
        {
            _showInfoUpdater = showInfoUpdater;
        }

        /// <summary>
        /// Initiates TvMaze data retrieving
        /// </summary>
        /// <returns></returns>
        [HttpGet("update")]
        public async Task<IActionResult> UpdateAsync()
        {
            try
            {
                await _showInfoUpdater.Update();
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
            return Ok("Scrapper Api - Database was updated");
        }
    }
}