using Mapper.Domain.Entities;

namespace Mapper.Application.Repositories;

public class VehicleRepository : IVehicleRepository
{
    public Vehicle GetVehicle(string regNo)
    {
        return new Vehicle
        {
            RegistrationNumber = "ABC123",
            Manufacturer = "Volvo",
            Model = "245DL",
            ModelYear = "1982",
            Mileage = 250000
        };
    }

    public IList<Vehicle> ListVehicles()
    {
        return [
            new Vehicle{RegistrationNumber = "ABC123", Manufacturer = "Volvo",Model = "245DL",ModelYear = "1982",Mileage = 250000},
            new Vehicle{RegistrationNumber = "ABC456", Manufacturer = "Fiat",Model = "Uno",ModelYear = "1991",Mileage = 220000},
            new Vehicle{RegistrationNumber = "ABC789", Manufacturer = "Ford",Model = "Mustang",ModelYear = "1967",Mileage = 465000}
        ];

    }
}
