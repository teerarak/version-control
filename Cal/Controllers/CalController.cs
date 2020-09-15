using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Cal.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CalController> _logger;

        public CalController(ILogger<CalController> logger)
        {
            _logger = logger;
        }

        [HttpPost("Pow")]
        public double power(double num1, double num2)
        {
            return Math.Pow(num1, num2);
        }
    }
}
