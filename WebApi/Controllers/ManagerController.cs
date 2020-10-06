using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Manager;
using Business.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [Authorize(AuthenticationSchemes = "Bearer",Roles ="manager")]
    [Route("api/Manager")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        private readonly ILogger<ManagerController> _logger;
        private readonly FlightManager _flightManager;

        public ManagerController(ILogger<ManagerController> logger, FlightManager flightManager)
        {
            _logger = logger;
            _flightManager = flightManager;
        }

        [HttpPost]
        [Route("Put")]
        public IActionResult Put(FlightModel model)
        {
            try
            {
                return Ok(new { success = true, data = _flightManager.Put(model) });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { error = ex.Message, success = false });
            }
        }
    }
}
