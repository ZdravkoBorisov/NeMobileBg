using NeMobileBg.Common.Models.Cars;

namespace NeMobileBg.Services.Contracts;

public interface ICarsService
{
    Task<CarsDataModel> GetDetailsAsync(string id);

    Task<IEnumerable<CarsSearchModel>> GetCarsSearchDataAsync();

    Task<IEnumerable<CarsSearchResponseModel>> GetBySearchCriteriaAsync(CarsSearchModel searchModel);

    Task EditAsync(CarsDataModel editModel);
    Task Delete(string id);
}
