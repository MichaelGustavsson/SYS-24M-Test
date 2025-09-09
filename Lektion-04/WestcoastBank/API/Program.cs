using Microsoft.EntityFrameworkCore;
using Persistence;
using Services.Interfaces;
// using Services.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDev"));
});

// builder.Services.AddScoped<IAccountRepository, AccountRepository>();

var app = builder.Build();


app.MapControllers();

app.Run();
