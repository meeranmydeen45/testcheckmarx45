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

        [HttpPost("request")]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(ErrorResponse), 500)]
        public async Task<IActionResult> CreateNewApprovalRequest([FromBody] NewApprovalRequest approvalRequest)
        {
            if (approvalRequest == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid request data.");
            }

            return Ok("Completed");
        }
    }
}
