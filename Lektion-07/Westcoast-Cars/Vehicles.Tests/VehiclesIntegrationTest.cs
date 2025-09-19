using System.Text.Json;
using Microsoft.Extensions.DependencyInjection;
using Vehicles.api;
using Vehicles.api.Data;
using Vehicles.api.Entities;
using Vehicles.Tests.Factories;
using Xunit.Abstractions;

namespace Vehicles.Tests;

public class VehiclesIntegrationTest : IClassFixture<VehicleApplicationFactory<Program>>, IDisposable
{
    private readonly VehicleApplicationFactory<Program> _factory;
    private readonly HttpClient _client;
    private readonly ITestOutputHelper _testOutputHelper;

    public VehiclesIntegrationTest(VehicleApplicationFactory<Program> factory, ITestOutputHelper testOutputHelper)
    {
        _factory = factory;
        _client = _factory.CreateClient();
        _testOutputHelper = testOutputHelper;
        // Sätta upp en test/dummy database i minnet...
        SetupDatabase();
    }

    private void SetupDatabase()
    {
        using var scope = _factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<VehiclesDbContext>();
        context.Database.EnsureCreated();

        context.Vehicles.Add(new Vehicle { Manufacturer = "Volvo", Model = "245DL", ModelYear = "1982", Mileage = 165000 });
        context.SaveChanges();
    }

    [Fact]
    public async Task VehiclesController_ListVehicles_ShouldReturn_Vehicles()
    {
        // Act + Arrange...
        var result = await _client.GetAsync("https://localhost:5001/api/vehicles");
        result.EnsureSuccessStatusCode();

        var content = await result.Content.ReadAsStringAsync();
        _testOutputHelper.WriteLine($"Content: {content}");

        var json = JsonDocument.Parse(content);
        var data = json.RootElement.GetProperty("data");
        var model = data[0].GetProperty("model").GetString();
        _testOutputHelper.WriteLine($"Model: {model}");

        Assert.Equal("245DL", model);
    }

    public void Dispose()
    {
        using var scope = _factory.Services.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<VehiclesDbContext>();
        context.Database.EnsureDeleted();
        GC.SuppressFinalize(this);
    }
}
