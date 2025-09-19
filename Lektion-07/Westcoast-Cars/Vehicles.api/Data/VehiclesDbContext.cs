using Microsoft.EntityFrameworkCore;
using Vehicles.api.Entities;

namespace Vehicles.api.Data;

public class VehiclesDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Vehicle> Vehicles { get; set; }
}
