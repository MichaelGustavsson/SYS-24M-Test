using Mapper.Application.Core;
using Mapper.Application.Repositories;
using Mapper.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IVehicleRepository, VehicleRepository>();
builder.Services.AddScoped<IVehicleService, VehicleService>();
builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
