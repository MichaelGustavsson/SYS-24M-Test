using Mapper.Domain.Entities;

namespace Mapper.Application.Repositories;

public class VehicleRepository : IVehicleRepository
{
    public Vehicle CreateVehicle(Vehicle vehicle)
    {
        return new Vehicle
        {
            RegNo = vehicle.RegNo,
            Make = vehicle.Make,
            Model = vehicle.Model,
            ModelYear = vehicle.ModelYear,
            Mileage = vehicle.Mileage
        };
    }

    public Vehicle GetVehicle(string regNo)
    {
        return new Vehicle
        {
            RegNo = "ABC123",
            Make = "Volvo",
            Model = "245DL",
            ModelYear = "1982",
            Mileage = 250000
        };
    }

    public IList<Vehicle> ListVehicles()
    {
        return [
            new Vehicle{RegNo = "ABC123", Make = "Volvo",Model = "245DL",ModelYear = "1982",Mileage = 250000},
            new Vehicle{RegNo = "ABC456", Make = "Fiat",Model = "Uno",ModelYear = "1991",Mileage = 220000},
            new Vehicle{RegNo = "ABC789", Make = "Ford",Model = "Mustang",ModelYear = "1967",Mileage = 465000}
        ];

    }
}
