using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using pfmservice.Models;

namespace pfmservice.Controllers
{
    [ApiController]
    [Route("/analytics")]
    public class AnalyticsController : ControllerBase
    {
        
        private readonly ILogger<AnalyticsController> _logger;

        public AnalyticsController(ILogger<AnalyticsController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/spending-analytics")]
        public IActionResult GetSpendingAnalytics([FromQuery] string catCode,[FromQuery] DateTime? startDate, [FromQuery]DateTime? endDate,[FromQuery] Direction direction)
        {
            return Ok();
        }

    }
}