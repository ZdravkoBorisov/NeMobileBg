namespace NeMobileBg.Data.Models;

public class Vehicle
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [MinLength(2)]
    public string Make { get; set; } = default!;

    [Required]
    [MinLength(2)]
    public string Model { get; set; } = default!;

    [Required]
    [Precision(9,0)]
    [Range(1, 99999999)]
    public decimal Price { get; set; } = default!;

    [Required]
    [Range(1, 3000)]
    public int HorsePower { get; set; } = default!;

    [Required]
    [MinLength(10)]
    [MaxLength(5000)]
    public string Description { get; set; } = default!;

    [Required]
    public byte[]? ImageUrl { get; set; } = default!;

    [Required]
    [MinLength(2)]
    public string Color { get; set; } = default!;

    [Required]

    public string Year { get; set; } = default!;

    [Range(10, 2000000)]
    public int Mileage { get; set; }

    public string? EuroStandard { get; set; }

    [Required]
    public string Gearbox { get; set; } = default!;

    [Required]
    [MinLength(2)]
    public string Condition { get; set; } = default!;

    [Required]
    [MinLength(2)]
    public string FuelType { get; set; } = default!;

    public string CreatedOn { get; set; } = default!;

    public string UserId { get; set; } = default!;

    public ApplicationUser Owner { get; set; } = default!;
}
