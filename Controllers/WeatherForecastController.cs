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

        [HttpPost("request")]
        [ProducesResponseType(204)]
        [ProducesResponseType(typeof(ErrorResponse), 500)]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateNewApprovalRequest([FromBody] NewApprovalRequest approvalRequest)
        {
            if (approvalRequest == null || !ModelState.IsValid)
            {
                return BadRequest("Invalid request data.");
            }

            //HtmlSanitizer sanitizer = new HtmlSanitizer();
            //approvalRequest.Description = sanitizer.Sanitize(approvalRequest.Description);
            //approvalRequest.PONumber = sanitizer.Sanitize(approvalRequest.PONumber);

            //approvalRequest.Items.ForEach(item =>
            //{
            //    item.Comment = sanitizer.Sanitize(item.Comment);
            //    item.DeliveryAddress = sanitizer.Sanitize(item.DeliveryAddress);
            //    item.Supplier = sanitizer.Sanitize(item.Supplier);
            //    item.VendorId = sanitizer.Sanitize(item.VendorId);
            //});


            return Ok("Completed");
        }
    }
}
