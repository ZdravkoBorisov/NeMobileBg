using Microsoft.EntityFrameworkCore;

namespace NeMobileBg.Data.Models;

public class Tyre
{
    public string Id { get; set; } = Guid.NewGuid().ToString();

    public string Make { get; set; } = default!;

    public int Height { get; set; }

    public int Width { get; set; }

    public int Inches { get; set; }

    public int DOT { get; set; }

    public string Season { get; set; } = default!;

    public string TyreIndex { get; set; } = default!;

    public string SpeedIndex { get; set; } = default!;

    public string Description { get; set; } = default!;

    [Precision(4,2)]
    public decimal Price { get; set; }

    public string UserId { get; set; } = default!;

    public ApplicationUser Owner { get; set; } = default!;
}
