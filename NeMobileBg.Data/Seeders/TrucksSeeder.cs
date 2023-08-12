using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeMobileBg.Data.Models;

namespace NeMobileBg.Data.Seeders;

internal class TrucksSeeder : IEntityTypeConfiguration<Truck>
{
    public void Configure(EntityTypeBuilder<Truck> builder)
    {
        builder.HasData(this.GenerateTrucks());
    }
    private List<Truck> GenerateTrucks()
    {
        var result = new List<Truck>();
       
        for (int i = 1; i < 23; i++)
        {
            var truck = new Truck
            {
                Make = "Brand" + i,
                Model = "Model" + i,
                Year = 2000 + i,
                Price = 10000 * i,
                Color = GetRandomColor(),
                HorsePower = 100 + i,
                FuelType = GetRandomFuelType(),
                Gearbox = GetRandomGearbox(),
                EuroStandard = "Euro " + (i % 6),
                Mileage = 100 * i,
                Description = "Description for Car " + i,
                Axles = 8,
                Condition = "Used",
                CreatedOn = DateTime.UtcNow.AddHours(-i).ToString(),
                UserId = GetRandomUserId(),
            };

            result.Add(truck);
        }
        return result;
    }

    private static string GetRandomColor()
    {
        string[] colors = { "Red", "Blue", "Green", "White", "Black", "Silver", "Gray" };
        Random random = new();
        return colors[random.Next(colors.Length)];
    }

    private static string GetRandomFuelType()
    {
        string[] fuelTypes = { "Gasoline", "Diesel", "Hybrid", "Electric" };
        Random random = new();
        return fuelTypes[random.Next(fuelTypes.Length)];
    }

    private static string GetRandomGearbox()
    {
        string[] gearboxes = { "Manual", "Automatic" };
        Random random = new();
        return gearboxes[random.Next(gearboxes.Length)];
    }

    private static string GetRandomUserId()
    {
        string[] usersIds =
        {
                "037f69eb-1390-435f-a085-e738fb60e93e",
                "296290bd-402b-4dc7-922f-3586f8d0c882",
                "3035f543-8ce5-457d-8073-c086473cf18a",
                "4a73c6d5-f1be-478f-af3f-e81d3ab8fbe5",
                "5856091b-d323-445d-a07b-5c28db656393",
                "824856e7-f56b-4f18-807f-d75e04c81ed0"
            };
        Random random = new();
        return usersIds[random.Next(usersIds.Length)];

    }
}
