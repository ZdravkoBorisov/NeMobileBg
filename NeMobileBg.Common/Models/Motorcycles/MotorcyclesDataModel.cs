using Microsoft.AspNetCore.Http;
using NeMobileBg.Data.Models;

namespace NeMobileBg.Common.Models.Cars;

public class MotorcyclesDataModel : Motorcycle
{
    public IFormFile NewImage { get; set; } = default!;
}
