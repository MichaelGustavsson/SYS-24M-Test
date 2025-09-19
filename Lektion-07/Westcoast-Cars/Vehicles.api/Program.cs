using Microsoft.EntityFrameworkCore;
using Vehicles.api.Data;

namespace Vehicles.api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        if (builder.Environment.EnvironmentName != "Test")
        {
            builder.Services.AddDbContext<VehiclesDbContext>(options =>
            {
                options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });
        }

        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        app.MapControllers();

        app.Run();
    }
}
