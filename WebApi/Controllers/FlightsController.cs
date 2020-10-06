using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Manager;
using Business.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/Flights")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly ILogger<FlightsController> _logger;
        private readonly FlightManager _flightManager;

        public FlightsController(ILogger<FlightsController> logger,FlightManager flightManager)
        {
            _logger = logger;
            _flightManager = flightManager;
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("List")]
        public IActionResult List()
        {
            try
            {
                return Ok(new { success = true, data = _flightManager.List() });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { error = ex.Message, success = false });
            }

        }


    }
}
