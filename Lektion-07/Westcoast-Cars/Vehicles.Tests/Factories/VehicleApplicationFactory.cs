using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Vehicles.api.Data;

namespace Vehicles.Tests.Factories;

public class VehicleApplicationFactory<Program> : WebApplicationFactory<Program> where Program : class
{
    protected override IHost CreateHost(IHostBuilder builder)
    {
        builder.UseEnvironment("Test");

        builder.ConfigureServices(services =>
        {
            services.AddDbContext<VehiclesDbContext>(opt => opt.UseInMemoryDatabase("vehicleTestDb"));
        });

        return base.CreateHost(builder);
    }
}
