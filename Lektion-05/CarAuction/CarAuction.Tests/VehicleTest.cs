using CarAuction.App.Classes;

namespace CarAuction.Tests;

public class VehicleTest
{
    [Fact]
    public void Vehicle_Should_InitializeConstructor_Correct()
    {
        // Arrange...
        var vehicle = new Vehicle("KIA", "EV6", "2022");

        // Act...
        // var make = vehicle.Make;

        // Act + Assert...
        Assert.Equal("kia", vehicle.Make, ignoreCase: true);
        Assert.Equal("ev6", vehicle.Model, ignoreCase: true);
        Assert.Equal("2022", vehicle.ModelYear, ignoreCase: true);

        // Assert...
        // Assert.Equal("kia", make, ignoreCase: true);
    }

    [Fact]
    public void Vehicle_VehicleName_ShouldReturn_Make_Model_ModelYear()
    {
        var vehicle = new Vehicle("KIA", "EV6", "2022");

        Assert.Equal("kia ev6 - 2022", vehicle.VehicleName(), ignoreCase: true);
    }

    [Fact]
    public void Vehicle_VehicleName_ShouldStartWith_Make()
    {
        var vehicle = new Vehicle("KIA", "EV6", "2022");

        Assert.StartsWith("kia", vehicle.VehicleName(), StringComparison.InvariantCultureIgnoreCase);
    }

    [Fact]
    public void Vehicle_VehicleName_ShouldContain_ModelYear()
    {
        var vehicle = new Vehicle("KIA", "EV6", "2022");

        Assert.Contains("2022", vehicle.VehicleName(), StringComparison.InvariantCultureIgnoreCase);
    }

    [Fact]
    public void Vehicle_Mileage_ShouldReturnNull_WhenNotExists()
    {
        var vehicle = new Vehicle("KIA", "EV6", "2022");

        // Act + Assert...
        Assert.Null(vehicle.Mileage);
    }

    [Fact]
    public void Vehicle_Mileage_ShouldNotReturnNull_WhenExists()
    {
        var vehicle = new Vehicle("KIA", "EV6", "2022")
        {
            // Act...
            Mileage = 25000
        };
        // Assert...
        Assert.NotNull(vehicle.Mileage);
    }
}
