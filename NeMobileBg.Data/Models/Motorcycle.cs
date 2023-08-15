using System.ComponentModel.DataAnnotations;

namespace NeMobileBg.Data.Models;

public class Motorcycle : Vehicle
{
    public string? RequiredLicense { get; set; }

    [Required]
    [MinLength(3)]
    public string Category { get; set; } = default!;

}
