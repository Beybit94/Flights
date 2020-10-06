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
    [Authorize(AuthenticationSchemes = "Bearer", Roles = "admin")]
    [Route("api/Admin")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly ILogger<AdminController> _logger;
        private readonly FlightManager _flightManager;

        public AdminController(ILogger<AdminController> logger, FlightManager flightManager)
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
    }
}
