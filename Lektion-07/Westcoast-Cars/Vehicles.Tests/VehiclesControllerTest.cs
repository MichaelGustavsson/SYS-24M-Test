using System.Text.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Vehicles.api;
using Xunit.Abstractions;

namespace Vehicles.Tests;

public class VehiclesControllerTest(WebApplicationFactory<Program> factory, ITestOutputHelper testOutputHelper)
    : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly HttpClient _client = factory.CreateClient();

    [Fact]
    public async Task VehiclesController_FindVehicle()
    {
        // Arrange...
        int id = 1;

        // Act...
        var result = await _client.GetAsync($"https://localhost:5001/api/vehicles/{id}");
        result.EnsureSuccessStatusCode();

        // var content = result.Content;
        // testOutputHelper.WriteLine("Raw content: {0}", content.ToString());
        var content = await result.Content.ReadAsStringAsync();
        testOutputHelper.WriteLine("Content: {0}", content);

        var json = JsonDocument.Parse(content);
        testOutputHelper.WriteLine($"Content: {json}");

        // return Ok(new { Success = true, Data = vehicle });
        var data = json.RootElement.GetProperty("data");
        testOutputHelper.WriteLine($"Data: {data}");

        var vehicleId = data.GetProperty("id").GetInt32();
        var manufacturer = data.GetProperty("manufacturer").GetString();
        var model = data.GetProperty("model").GetString();
        var modelYear = data.GetProperty("modelYear").GetString();
        testOutputHelper.WriteLine($"Vehicle: {id} {manufacturer} {model}");

        // Assert...
        Assert.Equal("245DL", model);
        Assert.Equal("Volvo", manufacturer);
        Assert.Equal("1982", modelYear);
        Assert.Equal(id, vehicleId);
    }
}
