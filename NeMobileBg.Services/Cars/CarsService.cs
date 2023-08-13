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

    public async Task<IEnumerable<CarsSearchModel>> GetCarsSearchData()
    {
        var cars = await this._repository.GetAllAsync<Car>();

        var result = cars.Select(x => new CarsSearchModel
        {
            Make = x.Make,
            Model = x.Model
        });

        return result;
    }

    public async Task<IEnumerable<CarsSearchResponseModel>> GetBySearchCriteria(CarsSearchModel searchModel)
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
                Make = car.Make,
                Model = car.Model,
                Description = car.Description,
                ImageUrl = car.ImageUrl,
                Price = car.Price,
                Year = car.Year,
                Category = car.Category,
                Gearbox = car.Gearbox,
                CreatedOn = car.CreatedOn
            };

            result.Add(carModel);
        }

        return result;
    }
}
