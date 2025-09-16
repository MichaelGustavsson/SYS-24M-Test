using Mapper.Domain.Entities;

namespace Mapper.Application.Repositories;

public interface IVehicleRepository
{
    Vehicle GetVehicle(string regNo);
    IList<Vehicle> ListVehicles();
}
