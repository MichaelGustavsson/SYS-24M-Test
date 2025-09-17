using AutoMapper;
using Mapper.Application.DTOs;
using Mapper.Domain.Entities;

namespace Mapper.Application.Core;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Vehicle => VehicleDto
        CreateMap<Vehicle, VehicleDto>()
            // Vi ska till Registrationnummber, Hämtar ifrån RegNo
            .ForMember(dest => dest.RegistrationNumber, opt => opt.MapFrom(src => src.RegNo))
            .ForMember(dest => dest.Manufacturer, opt => opt.MapFrom(src => src.Make));
        // CreateMap<Vehicle, VehicleDto>();
        // VehicleDto => Vehicle
        CreateMap<CreateVehicleDto, Vehicle>()
            .ForMember(dest => dest.RegNo, opt => opt.MapFrom(src => src.RegistrationNumber))
            .ForMember(dest => dest.Make, opt => opt.MapFrom(src => src.Manufacturer));
    }
}
