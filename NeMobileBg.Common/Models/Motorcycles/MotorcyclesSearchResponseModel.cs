namespace NeMobileBg.Common.Models.Cars;

public class MotorcyclesSearchResponseModel
{
    public string CarId { get; set; } = default!;

    public string Make { get; set; } = default!;

    public string Model { get; set; } = default!;

    public string Description { get; set; } = default!;

    public string OwnerId { get; set; } = default!;

    public byte[]? ImageUrl { get; set; }

    public decimal Price { get; set; } = default!;

    public string Year { get; set; } = default!;

    public string Category { get; set; } = default!;

    public string Gearbox { get; set; } = default!;

    public string CreatedOn { get; set; } = default!;
}
