using Application.Core;
using Application.Interfaces;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDev"));
});

// Dependency injection...
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly);

var app = builder.Build();


app.MapControllers();

app.Run();
