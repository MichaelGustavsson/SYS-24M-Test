using Mapper.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace Mapper.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController(IVehicleService vehicleService) : ControllerBase
    {
        [HttpGet]
        public ActionResult ListAllVehicles()
        {
            return Ok(new { Success = true, Data = vehicleService.ListAllVehicles() });
        }

        [HttpGet("{regNo}")]
        public ActionResult FindVehicle(string regNo)
        {
            return Ok(new { Success = true, Data = vehicleService.FindVehicle(regNo) });
        }
    }
}
