using Mapper.Application.DTOs;
using Mapper.Application.Repositories;

namespace Mapper.Application.Services;

public class VehicleService(IVehicleRepository vehicleRepository) : IVehicleService
{
    public VehicleDto FindVehicle(string regnumber)
    {
        var vehicle = vehicleRepository.GetVehicle(regnumber);
        return new VehicleDto
        {
            RegistrationNumber = vehicle.RegistrationNumber,
            Manufacturer = vehicle.Manufacturer,
            Model = vehicle.Model,
            ModelYear = vehicle.ModelYear,
            Mileage = vehicle.Mileage
        };
    }

    public IList<VehicleDto> ListAllVehicles()
    {
        var result = vehicleRepository.ListVehicles();
        List<VehicleDto> vehicles = [];

        foreach (var vehicle in result)
        {
            vehicles.Add(new VehicleDto
            {
                Id = vehicle.Id,
                RegistrationNumber = vehicle.RegistrationNumber,
                Manufacturer = vehicle.Manufacturer,
                Model = vehicle.Model,
                ModelYear = vehicle.ModelYear,
                Mileage = vehicle.Mileage
            });
        }

        return vehicles;
    }
}
