using NeMobileBg.Common.Models.Cars;
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

    public Task<string> CreateAsync(MotorcyclesDataModel dataModel, string ownerId)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task EditAsync(MotorcyclesDataModel editModel)
    {
        throw new NotImplementedException();
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

        if (!string.IsNullOrEmpty(searchModel.EuroStandard))
        {
            query = query.Where(x => x.EuroStandard == searchModel.EuroStandard);
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
                CarId = motorcycle.Id,
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

    public Task<MotorcyclesDataModel> GetDetailsAsync(string id)
    {
        throw new NotImplementedException();
    }
}
