using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Manager;
using Business.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
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

        [HttpGet]
        [ActionName("List")]
        [Route("List")]
        public async Task<IEnumerable<FlightModel>> List()
        {
            return await _flightManager.ListAsync();
        }
    }
}
