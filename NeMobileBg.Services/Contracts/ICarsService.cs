namespace NeMobileBg.Services.Contracts;

public interface ICarsService
{
    Task<string> CreateAsync(CarsDataModel dataModel, string ownerId);
    Task<CarsDataModel> GetDetailsAsync(string id);

    Task<IEnumerable<CarsSearchModel>> GetCarsSearchDataAsync();

    Task<IEnumerable<CarsSearchResponseModel>> GetBySearchCriteriaAsync(CarsSearchModel searchModel);

    Task EditAsync(CarsDataModel editModel);
    Task Delete(string id);
}
