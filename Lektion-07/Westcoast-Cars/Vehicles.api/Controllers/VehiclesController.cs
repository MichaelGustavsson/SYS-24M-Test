using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vehicles.api.Data;

namespace Vehicles.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiclesController(VehiclesDbContext context) : ControllerBase
    {
        [HttpGet("{id}")]
        public ActionResult FindVehicle(int id)
        {
            var vehicle = new
            {
                Id = id,
                Manufacturer = "Volvo",
                Model = "245DL",
                ModelYear = "1982"
            };

            return Ok(new { Success = true, Data = vehicle });
        }

        [HttpGet]
        public async Task<ActionResult> ListVehicles()
        {
            var result = await context.Vehicles.ToListAsync();
            await Task.Delay(2);
            return Ok(new { Success = true, Data = result });
        }
    }
}
