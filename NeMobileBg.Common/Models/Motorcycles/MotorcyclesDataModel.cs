using Microsoft.AspNetCore.Http;
using NeMobileBg.Data.Models;

namespace NeMobileBg.Common.Models.Motorcycles;

public class MotorcyclesDataModel : Motorcycle
{
    public IFormFile NewImage { get; set; } = default!;
}
