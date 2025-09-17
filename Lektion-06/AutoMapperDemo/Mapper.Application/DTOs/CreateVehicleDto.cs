namespace Mapper.Application.DTOs;

public class CreateVehicleDto
{
    public required string RegistrationNumber { get; set; }
    public required string Manufacturer { get; set; }
    public required string Model { get; set; }
    public required string ModelYear { get; set; }
    public int Mileage { get; set; }
}
