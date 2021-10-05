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

        [HttpPost]
        public IActionResult Post()
        {
            _logger.LogInformation("Controller: {0} - Action: {1}", GetRouteInfo().Item1, GetRouteInfo().Item2);
            return Ok("Weather Forecast added successfully!");
        }
        
        [HttpPut]
        public IActionResult Put()
        {
            _logger.LogWarning("Controller: {0} - Action: {1}", GetRouteInfo().Item1, GetRouteInfo().Item2);
            return Ok("Weather Forecast updated successfully!");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            _logger.LogError("Controller: {0} - Action: {1}", GetRouteInfo().Item1, GetRouteInfo().Item2);
            return Ok("Weather Forecast delete successfully!");
        }
    }
}
