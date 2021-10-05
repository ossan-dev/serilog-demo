using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serilog_demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        public BaseApiController()
        {

        }

        protected Tuple<string, string> GetRouteInfo()
        {
            if (RouteData.Values.TryGetValue("action", out var action) && RouteData.Values.TryGetValue("controller", out var controller))
            {
                return new Tuple<string, string>(controller.ToString(), action.ToString());
            }
            else
                throw new ArgumentNullException("Missing route values");
        }
    }
}
