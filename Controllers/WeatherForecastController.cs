using Ganss.Xss;
using Microsoft.AspNetCore.Mvc;
using WebApplicationWebAppCheckMarx.Models;

namespace WebApplicationWebAppCheckMarx.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get")]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(ErrorResponse), 500)]
        public async Task<IActionResult> Get()
        {
            return Ok("Completed");
        }

        [HttpPost("savePoint")]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(ErrorResponse), 500)]
        public async Task<IActionResult> AllSites([FromBody] SiteRequest siteRequest)
        {
            if (siteRequest == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid request data.");
            }

            return Ok("Completed");
        }

        [HttpPost("request/{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(ErrorResponse), 500)]
        public async Task<IActionResult> AllSitesData(int id)
        {
           
            return Ok("Completed");
        }
    }
}
