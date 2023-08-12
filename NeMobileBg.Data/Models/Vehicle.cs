using Microsoft.EntityFrameworkCore;

namespace NeMobileBg.Data.Models;

public class Vehicle
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Make { get; set; } = default!;

    public string Model { get; set; } = default!;

    [Precision(9,0)]
    public decimal Price { get; set; } = default!;

    public int HorsePower { get; set; } = default!;

    public string Description { get; set; } = default!;

    public byte[] ImageUrl { get; set; } = default!;

    public string Color { get; set; } = default!;

    public int Year { get; set; } = default!;

    public int Mileage { get; set; }

    public string? EuroStandart { get; set; }

    public string Gearbox { get; set; } = default!;

    public string Condition { get; set; } = default!;

    public string FuelType { get; set; } = default!;

    public string UserId { get; set; } = default!;

    public ApplicationUser Owner { get; set; } = default!;
}
