using Microsoft.AspNetCore.Http;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Common.Models.Motorcycles;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Services.Motorcycles;

public class MotorcyclesService : IMotorcycleService
{
    private readonly IRepository _repository;

    public MotorcyclesService(IRepository repository)
    {
        this._repository = repository;
    }

    public async Task<string> CreateAsync(MotorcyclesDataModel dataModel, string ownerId)
    {
        var motorcycle = new Motorcycle
        {
            Id = Guid.NewGuid().ToString(),
            Make = dataModel.Make,
            Model = dataModel.Model,
            Description = dataModel.Description,
            Price = dataModel.Price,
            Year = dataModel.Year,
            Category = dataModel.Category,
            CreatedOn = DateTime.UtcNow.ToString(),
            Color = dataModel.Color,
            Condition = dataModel.Condition,
            HorsePower = dataModel.HorsePower,
            Mileage = dataModel.Mileage,
            UserId = ownerId,
            FuelType = dataModel.FuelType,
            Gearbox = dataModel.Gearbox,
        };

        if (dataModel.NewImage != null)
        {
            var bytes = await this.GetBytes(dataModel.NewImage);
            motorcycle.ImageUrl = bytes;
        }

        await this._repository.AddAsync(motorcycle);
        await this._repository.SaveChangesAsync();

        return motorcycle.Id;
    }

    public async Task DeleteAsync(string id)
    {
        var motorcycle = await this._repository.GetByIdAsync<Motorcycle>(id);

        await this._repository.RemoveAsync(motorcycle);
        await this._repository.SaveChangesAsync();
    }

    public async Task EditAsync(MotorcyclesDataModel editModel)
    {
        var motorcycle = await this._repository.GetByIdAsync<Motorcycle>(editModel.Id);

        if (editModel.NewImage != null)
        {
            var imgBytes = await this.GetBytes(editModel.NewImage);
            motorcycle.ImageUrl = imgBytes;
        }

        motorcycle.Make = editModel.Make;
        motorcycle.Model = editModel.Model;
        motorcycle.Description = editModel.Description;
        motorcycle.Price = editModel.Price;
        motorcycle.Year = editModel.Year;
        motorcycle.Category = editModel.Category;
        motorcycle.Color = editModel.Color;
        motorcycle.Condition = editModel.Condition;
        motorcycle.HorsePower = editModel.HorsePower;
        motorcycle.Mileage = editModel.Mileage;

        await this._repository.UpdateAsync(motorcycle);
        await this._repository.SaveChangesAsync();
    }

    public async Task<IEnumerable<MotorcyclesSearchResponseModel>> GetBySearchCriteriaAsync(MotorcyclesSearchModel searchModel)
    {
        var result = new List<MotorcyclesSearchResponseModel>();

        var query = await this._repository.GetAllAsync<Motorcycle>();

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

        if (!string.IsNullOrEmpty(searchModel.Condition))
        {
            query = query.Where(x => x.Condition == searchModel.Condition);
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
            if (DateTime.TryParse(searchModel.FromYear, out DateTime fromYearDate))
            {
                query = query.Where(x => DateTime.Parse(x.Year) > fromYearDate);
            }
        }

        if (!string.IsNullOrEmpty(searchModel.ToYear))
        {
            if (DateTime.TryParse(searchModel.ToYear, out DateTime toYearDate))
            {
                query = query.Where(x => DateTime.Parse(x.Year) < toYearDate);
            }
        }


        var motorcycles = query.ToList();


        foreach (var motorcycle in motorcycles)
        {
            var motorcycleModel = new MotorcyclesSearchResponseModel
            {
                MotorcycleId = motorcycle.Id,
                Make = motorcycle.Make,
                Model = motorcycle.Model,
                Description = motorcycle.Description,
                ImageUrl = motorcycle.ImageUrl,
                Price = motorcycle.Price,
                Year = motorcycle.Year,
                Category = motorcycle.Category,
                CreatedOn = motorcycle.CreatedOn,
                OwnerId = motorcycle.UserId
            };

            result.Add(motorcycleModel);
        }

        return result;
    }

    public async Task<IEnumerable<MotorcyclesSearchModel>> GetMotorcyclesSearchDataAsync()
    {
        var motorcycles = await this._repository.GetAllAsync<Motorcycle>();

        var result = motorcycles.Select(x => new MotorcyclesSearchModel
        {
            Make = x.Make,
            Model = x.Model
        });

        return result;
    }

    public async Task<MotorcyclesDataModel> GetDetailsAsync(string id)
    {
        try
        {
            var motorcycle = await this._repository.GetByIdAsync<Motorcycle>(id);
            if (motorcycle == null)
            {
                return null;
            }
            var result = new MotorcyclesDataModel
            {
                Id = motorcycle.Id,
                Make = motorcycle.Make,
                Model = motorcycle.Model,
                Description = motorcycle.Description,
                ImageUrl = motorcycle.ImageUrl,
                Price = motorcycle.Price,
                Year = motorcycle.Year,
                Category = motorcycle.Category,
                CreatedOn = motorcycle.CreatedOn,
                Color = motorcycle.Color,
                Condition = motorcycle.Condition,
                HorsePower = motorcycle.HorsePower,
                Mileage = motorcycle.Mileage,
                UserId = motorcycle.UserId,
            };

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex);
            return null;
        }
    }

    private async Task<byte[]> GetBytes(IFormFile formFile)
    {
        await using var memoryStream = new MemoryStream();
        await formFile.CopyToAsync(memoryStream);
        return memoryStream.ToArray();
    }
}
