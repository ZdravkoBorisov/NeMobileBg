﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Seeders;

namespace NeMobileBg.Data;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    private readonly bool _seedFlag = true;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected ApplicationDbContext(UserManager<ApplicationUser> userManager,
                                   RoleManager<IdentityRole> roleManager)
    {
        this._userManager = userManager;
        this._roleManager = roleManager;
    }

    public DbSet<Car> Cars { get; set; } = default!;

    public DbSet<Truck> Trucks { get; set; } = default!;

    public DbSet<Motorcycle> Motorcycles { get; set; } = default!;

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
        }
    }
}
