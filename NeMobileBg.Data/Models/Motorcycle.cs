namespace NeMobileBg.Data.Models;

public class Motorcycle : Vehicle
{
    public string? RequiredLicense { get; set; }

    public string Category { get; set; } = default!;

}
