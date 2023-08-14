using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Common.Models.Motorcycles;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Services.Users;

public class UsersService : IUsersService
{
    private readonly IRepository _repository;

    public UsersService(IRepository repository)
    {
        this._repository = repository;
    }

    public async Task<IEnumerable<CarsDataModel>> GetMyCarsAsync(string userId)
    {
        var cars = await this._repository.GetAllAsync<Car>();
        var result = cars.Where(x => x.UserId == userId)
                         .Select(x => new CarsDataModel
                         {
                             Id = x.Id,
                             Make = x.Make,
                             Model = x.Model,
                             Description = x.Description,
                             Price = x.Price,
                             Year = x.Year,
                             Category = x.Category,
                             Gearbox = x.Gearbox,
                             Color = x.Color,
                             Condition = x.Condition,
                             EuroStandard = x.EuroStandard,
                             FuelType = x.FuelType,
                             HorsePower = x.HorsePower,
                             Mileage = x.Mileage,
                             Convertible = x.Convertible,
                             Doors = x.Doors,
                             Seats = x.Seats,
                             ImageUrl = x.ImageUrl,
                         }).ToList();

        return result;
    }

    public async Task<IEnumerable<CarsDataModel>> GetAllCarsAsync()
    {
        var cars = await this._repository.GetAllAsync<Car>();
        var result = cars.Select(x => new CarsDataModel
        {
            Id = x.Id,
            Make = x.Make,
            Model = x.Model,
            Description = x.Description,
            Price = x.Price,
            Year = x.Year,
            Category = x.Category,
            Gearbox = x.Gearbox,
            Color = x.Color,
            Condition = x.Condition,
            EuroStandard = x.EuroStandard,
            FuelType = x.FuelType,
            HorsePower = x.HorsePower,
            Mileage = x.Mileage,
            Convertible = x.Convertible,
            Doors = x.Doors,
            Seats = x.Seats,
            ImageUrl = x.ImageUrl,
            UserId = x.UserId,
        }).ToList();

        return result;
    }

    public async Task<IEnumerable<MotorcyclesDataModel>> GetMyMotorcyclesASync(string userId)
    {
        var motorcycles = await this._repository.GetAllAsync<Motorcycle>();
        var result = motorcycles.Where(x => x.UserId == userId)
                                .Select(x => new MotorcyclesDataModel
                                {
                                    Id = x.Id,
                                    Make = x.Make,
                                    Model = x.Model,
                                    Description = x.Description,
                                    Price = x.Price,
                                    Year = x.Year,
                                    Category = x.Category,
                                    Color = x.Color,
                                    Condition = x.Condition,
                                    HorsePower = x.HorsePower,
                                    Mileage = x.Mileage,
                                    ImageUrl = x.ImageUrl,
                                }).ToList();

        return result;
    }

    public async Task<IEnumerable<MotorcyclesDataModel>> GetAllMotorcyclesAsync()
    {
        var motorcycles = await this._repository.GetAllAsync<Motorcycle>();
        var result = motorcycles.Select(x => new MotorcyclesDataModel
        {
            Id = x.Id,
            Make = x.Make,
            Model = x.Model,
            Description = x.Description,
            Price = x.Price,
            Year = x.Year,
            Category = x.Category,
            Color = x.Color,
            Condition = x.Condition,
            HorsePower = x.HorsePower,
            Mileage = x.Mileage,
            ImageUrl = x.ImageUrl,
            UserId = x.UserId,
        }).ToList();

        return result;
    }
}
