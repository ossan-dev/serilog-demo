using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serilog_demo.Controllers
{
    public class WeatherForecastController : BaseApiController
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Controller: {0} - Action: {1}", GetRouteInfo().Item1, GetRouteInfo().Item2);
            return Ok("Weather Forecast successfully retrieved!");
        }
    }
}
