using Microsoft.AspNetCore.Http;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Services.Cars;

public class CarsService : ICarsService
{
    private readonly IRepository _repository;

    public CarsService(IRepository repository)
    {
        this._repository = repository;
    }

    public async Task Delete(string id)
    {
        var car = await this._repository.GetByIdAsync<Car>(id);

        await this._repository.RemoveAsync(car);
        await this._repository.SaveChangesAsync();
    }

    public async Task<CarsDataModel> GetDetailsAsync(string id)
    {
        try
        {
            var car = await this._repository.GetByIdAsync<Car>(id);
            if (car == null)
            {
                return null;
            }
            var result = new CarsDataModel
            {
                Id = car.Id,
                Make = car.Make,
                Model = car.Model,
                Description = car.Description,
                ImageUrl = car.ImageUrl,
                Price = car.Price,
                Year = car.Year,
                Category = car.Category,
                Gearbox = car.Gearbox,
                CreatedOn = car.CreatedOn,
                Color = car.Color,
                Condition = car.Condition,
                EuroStandard = car.EuroStandard,
                FuelType = car.FuelType,
                HorsePower = car.HorsePower,
                Mileage = car.Mileage,
                Convertible = car.Convertible,
                Doors = car.Doors,
                Seats = car.Seats,
                UserId = car.UserId,
            };

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return null;
        }

    }

    public async Task<IEnumerable<CarsSearchModel>> GetCarsSearchDataAsync()
    {
        var cars = await this._repository.GetAllAsync<Car>();

        var result = cars.Select(x => new CarsSearchModel
        {
            Make = x.Make,
            Model = x.Model
        });

        return result;
    }

    public async Task<IEnumerable<CarsSearchResponseModel>> GetBySearchCriteriaAsync(CarsSearchModel searchModel)
    {
        var result = new List<CarsSearchResponseModel>();

        var query = await this._repository.GetAllAsync<Car>();

        if (!string.IsNullOrEmpty(searchModel.Make))
        {
            query = query.Where(x => x.Make == searchModel.Make);
        }

        if (!string.IsNullOrEmpty(searchModel.Model))
        {
            query = query.Where(x => x.Model == searchModel.Model);
        }

        if (!string.IsNullOrEmpty(searchModel.Description))
        {
            query = query.Where(x => x.Description.Contains(searchModel.Description));
        }

        if (!string.IsNullOrEmpty(searchModel.Color))
        {
            query = query.Where(x => x.Color == searchModel.Color);
        }

        if (!string.IsNullOrEmpty(searchModel.EuroStandard))
        {
            query = query.Where(x => x.EuroStandard == searchModel.EuroStandard);
        }

        if (!string.IsNullOrEmpty(searchModel.Gearbox))
        {
            query = query.Where(x => x.Gearbox == searchModel.Gearbox);
        }

        if (!string.IsNullOrEmpty(searchModel.Condition))
        {
            query = query.Where(x => x.Condition == searchModel.Condition);
        }

        if (!string.IsNullOrEmpty(searchModel.FuelType))
        {
            query = query.Where(x => x.FuelType == searchModel.FuelType);
        }

        if (searchModel.HorsePowerFrom != 0)
        {
            query = query.Where(x => x.HorsePower > searchModel.HorsePowerFrom);
        }

        if (searchModel.HorsePowerTo != 0)
        {
            query = query.Where(x => x.HorsePower < searchModel.HorsePowerTo);
        }

        if (searchModel.MileageFrom != 0)
        {
            query = query.Where(x => x.Mileage > searchModel.MileageFrom);
        }

        if (searchModel.MileageTo != 0)
        {
            query = query.Where(x => x.Mileage < searchModel.MileageTo);
        }

        if (!string.IsNullOrEmpty(searchModel.FromYear))
        {
            DateTime fromYearDate;
            if (DateTime.TryParse(searchModel.FromYear, out fromYearDate))
            {
                query = query.Where(x => DateTime.Parse(x.Year) > fromYearDate);
            }
        }

        if (!string.IsNullOrEmpty(searchModel.ToYear))
        {
            DateTime toYearDate;
            if (DateTime.TryParse(searchModel.ToYear, out toYearDate))
            {
                query = query.Where(x => DateTime.Parse(x.Year) < toYearDate);
            }
        }


        var cars = query.ToList();


        foreach (var car in cars)
        {
            var carModel = new CarsSearchResponseModel
            {
                CarId = car.Id,
                Make = car.Make,
                Model = car.Model,
                Description = car.Description,
                ImageUrl = car.ImageUrl,
                Price = car.Price,
                Year = car.Year,
                Category = car.Category,
                Gearbox = car.Gearbox,
                CreatedOn = car.CreatedOn,
                OwnerId = car.UserId
            };

            result.Add(carModel);
        }

        return result;
    }

    public async Task<IEnumerable<CarsSearchResponseModel>> GetLatestCarsAsync()
    {
        var cars = await this._repository.GetAllAsync<Car>();

        var result = cars.OrderByDescending(x => x.CreatedOn).Take(3).Select(x => new CarsSearchResponseModel
        {
            CarId = x.Id,
            Make = x.Make,
            Model = x.Model,
            Description = x.Description,
            ImageUrl = x.ImageUrl,
            Price = x.Price,
            Year = x.Year,
            Category = x.Category,
            Gearbox = x.Gearbox,
            CreatedOn = x.CreatedOn
        });

        return result;
    }

    public async Task EditAsync(CarsDataModel editModel)
    {
        var car = await this._repository.GetByIdAsync<Car>(editModel.Id);

        if (editModel.NewImage != null)
        {
            var imgBytes = await GetBytes(editModel.NewImage);
            car.ImageUrl = imgBytes;
        }

        car.Make = editModel.Make;
        car.Model = editModel.Model;
        car.Description = editModel.Description;
        car.Price = editModel.Price;
        car.Year = editModel.Year;
        car.Category = editModel.Category;
        car.Gearbox = editModel.Gearbox;
        car.Color = editModel.Color;
        car.Condition = editModel.Condition;
        car.EuroStandard = editModel.EuroStandard;
        car.FuelType = editModel.FuelType;
        car.HorsePower = editModel.HorsePower;
        car.Mileage = editModel.Mileage;
        car.Convertible = editModel.Convertible;
        car.Doors = editModel.Doors;
        car.Seats = editModel.Seats;

        await this._repository.UpdateAsync(car);
        await this._repository.SaveChangesAsync();
    }

    public static async Task<byte[]> GetBytes(IFormFile formFile)
    {
        await using var memoryStream = new MemoryStream();
        await formFile.CopyToAsync(memoryStream);
        return memoryStream.ToArray();
    }
}
