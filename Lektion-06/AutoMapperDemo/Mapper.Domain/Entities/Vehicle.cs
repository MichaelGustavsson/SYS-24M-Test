namespace Mapper.Domain.Entities;

public class Vehicle
{
    public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
    public required string RegNo { get; set; }
    public required string Make { get; set; }
    public required string Model { get; set; }
    public required string ModelYear { get; set; }
    public int Mileage { get; set; }
}
