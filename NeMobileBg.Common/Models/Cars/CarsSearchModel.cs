using Microsoft.AspNetCore.Http;

namespace NeMobileBg.Common.Models.Cars
{
    public class CarsSearchModel
    {
        public string Make { get; set; } = default!;

        public string Model { get; set; } = default!;

        public decimal Price { get; set; } = 0;

        public int HorsePower { get; set; } = 0;

        public string Description { get; set; } = default!;

        public IFormFile? ImageUrl { get; set; } = null;

        public string Color { get; set; } = default!;

        public string Year { get; set; } = default!;

        public int Mileage { get; set; } = 0;

        public string EuroStandard { get; set; } = default!;

        public string Gearbox { get; set; } = default!;

        public string Condition { get; set; } = default!;

        public string FuelType { get; set; } = default!;
    }
}
