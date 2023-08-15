using Microsoft.AspNetCore.Http;
using NeMobileBg.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace NeMobileBg.Common.Models.Motorcycles;

public class MotorcyclesDataModel : Motorcycle
{
    [Required]
    public IFormFile NewImage { get; set; } = default!;
}
