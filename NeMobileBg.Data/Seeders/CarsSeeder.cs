using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeMobileBg.Data.Models;

namespace NeMobileBg.Data.Seeders
{
    internal class CarsSeeder : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasData(this.GenerateCars());
        }

        private List<Car> GenerateCars()
        {
            var result = new List<Car>();

            for (int i = 0; i < 100; i++)
            {
                var car = new Car
                {
                    Make = "Make" + i,
                    Model = "Model" + i,
                    Year = 2000 + i,
                    Price = 10000 + i,
                    Color = "Color" + i,
                    HorsePower = 100 + i,
                    FuelType = "Fuel" + i,
                    Gearbox = "Gearbox" + i,
                    Doors = 4 + i,
                    Seats = 4 + i,
                    EuroStandart = "EuroStandart" + i,
                    Mileage = 100000 + i,
                    Description = "Description" + i,
                    UserId = "1",
                };

                result.Add(car);
            }
            return result;
        }
    }
}
