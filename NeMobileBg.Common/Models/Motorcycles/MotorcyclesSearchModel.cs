using Microsoft.AspNetCore.Http;

namespace NeMobileBg.Common.Models.Motorcycles;

public class MotorcyclesSearchModel
{
    public string Make { get; set; } = default!;

    public string Model { get; set; } = default!;

    public decimal Price { get; set; } = 0;

    public int HorsePowerFrom { get; set; } = 0;

    public int HorsePowerTo { get; set; } = 0;

    public string Description { get; set; } = default!;

    public string Category { get; set; } = default!;

    public IFormFile? ImageUrl { get; set; } = null;

    public string Color { get; set; } = default!;

    public string FromYear { get; set; } = default!;

    public string ToYear { get; set; } = default!;

    public int MileageFrom { get; set; } = 0;

    public int MileageTo { get; set; } = 0;

    public string Condition { get; set; } = default!;

    public string FuelType { get; set; } = default!;
}
