using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeMobileBg.Data.Models;

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

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
