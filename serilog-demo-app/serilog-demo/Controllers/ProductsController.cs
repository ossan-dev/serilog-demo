using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serilog_demo.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Controller: {0} - Action: {1}", GetRouteInfo().Item1, GetRouteInfo().Item2);
            return Ok("Product retrieved successfully!");
        }

        [HttpPost]
        public IActionResult Post()
        {
            _logger.LogInformation("Controller: {0} - Action: {1}", GetRouteInfo().Item1, GetRouteInfo().Item2);
            return Ok("Product added successfully!");
        }

        [HttpPut]
        public IActionResult Put()
        {
            _logger.LogWarning("Controller: {0} - Action: {1}", GetRouteInfo().Item1, GetRouteInfo().Item2);
            return Ok("Product updated successfully!");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            _logger.LogError("Controller: {0} - Action: {1}", GetRouteInfo().Item1, GetRouteInfo().Item2);
            return Ok("Product delete successfully!");
        }
    }
}
