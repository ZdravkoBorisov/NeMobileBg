using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Seeders;

namespace NeMobileBg.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    private readonly bool _seedFlag = true;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Car> Cars { get; set; } = default!;

    public DbSet<Truck> Trucks { get; set; } = default!;

    public DbSet<Motorcycle> Motorcycles { get; set; } = default!;

    public DbSet<Tyre> Tyres { get; set; } = default!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        if (this._seedFlag)
        {
            //builder.ApplyConfiguration(new UsersSeeder());
            builder.ApplyConfiguration(new CarsSeeder());
            builder.ApplyConfiguration(new TrucksSeeder());
            builder.ApplyConfiguration(new MotorcyclesSeeder());
            //builder.ApplyConfiguration(new RolesSeeder());
            //builder.ApplyConfiguration(new IdentityRolesUsersSeeder());
        }
    }
}
