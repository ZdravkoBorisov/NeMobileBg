using Microsoft.AspNetCore.Http;
using NeMobileBg.Data.Models;

namespace NeMobileBg.Common.Models.Cars;

public class CarsDataModel : Car
{
    public IFormFile NewImage { get; set; } = default!;
}
