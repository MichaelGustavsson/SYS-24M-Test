namespace CarAuction.App.Classes;

public class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public string ModelYear { get; set; }
    public int? Mileage { get; set; }
    public Vehicle(string make, string model, string modelYear)
    {
        ModelYear = modelYear;
        Model = model;
        Make = make;
    }

    public string VehicleName() => $"{Make} {Model} - {ModelYear}";
}
