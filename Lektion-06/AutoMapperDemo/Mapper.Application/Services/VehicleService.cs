using AutoMapper;
using Mapper.Application.DTOs;
using Mapper.Application.Repositories;
using Mapper.Domain.Entities;

namespace Mapper.Application.Services;

public class VehicleService(IVehicleRepository vehicleRepository, IMapper mapper) : IVehicleService
{
    public VehicleDto AddVehicle(CreateVehicleDto dto)
    {
        // 1. Gör om vår dto till entiteten Vehicle...
        // var vehicle = mapper.Map<Vehicle>(dto);
        // vehicleRepository.CreateVehicle(vehicle);
        var vehicle = vehicleRepository.CreateVehicle(mapper.Map<Vehicle>(dto));

        // 2. Gör om Vehicle entiteten vehicle till en dto...
        return mapper.Map<VehicleDto>(vehicle);
    }

    public VehicleDto FindVehicle(string regnumber)
    {
        var vehicle = vehicleRepository.GetVehicle(regnumber);
        return mapper.Map<VehicleDto>(vehicle);
    }

    public IList<VehicleDto> ListAllVehicles()
    {
        var result = vehicleRepository.ListVehicles();
        return mapper.Map<List<VehicleDto>>(result);
    }
}
