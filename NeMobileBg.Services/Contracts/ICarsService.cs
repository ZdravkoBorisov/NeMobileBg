using NeMobileBg.Common.Models.Cars;

namespace NeMobileBg.Services.Contracts;

public interface ICarsService
{
    Task<IEnumerable<CarsSearchModel>> GetCarsSearchData();
    Task<IEnumerable<CarsSearchResponseModel>> GetBySearchCriteria(CarsSearchModel searchModel);
}
