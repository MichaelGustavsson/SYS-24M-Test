using Mapper.Application.DTOs;

namespace Mapper.Application.Services;

public interface IVehicleService
{
    VehicleDto FindVehicle(string regnumber);
    IList<VehicleDto> ListAllVehicles();
}
