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
    [Route("api/Flights")]
    [ApiController]
    public class FlightsController : ControllerBase
    {
        private readonly ILogger<FlightsController> _logger;
        private readonly FlightManager _flightManager;

        public FlightsController(ILogger<FlightsController> logger, FlightManager flightManager)
        {
            _logger = logger;
            _flightManager = flightManager;
        }

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

        [Authorize(AuthenticationSchemes = "Bearer", Roles = "admin")]
        [HttpPost]
        [Route("Create")]
        public IActionResult Create(FlightModel model)
        {
            try
            {
                return Ok(new { success = true, data = _flightManager.Create(model) });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { error = ex.Message, success = false });
            }
        }

        [Authorize(AuthenticationSchemes = "Bearer", Roles = "admin")]
        [HttpPost]
        [Route("Edit")]
        public IActionResult Edit(FlightModel model)
        {
            try
            {
                return Ok(new { success = true, data = _flightManager.Edit(model) });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { error = ex.Message, success = false });
            }
        }

        [Authorize(AuthenticationSchemes = "Bearer", Roles = "admin")]
        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete(long Id)
        {
            try
            {
                _flightManager.Delete(Id);
                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { error = ex.Message, success = false });
            }
        }

        [Authorize(AuthenticationSchemes = "Bearer", Roles = "manager")]
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
