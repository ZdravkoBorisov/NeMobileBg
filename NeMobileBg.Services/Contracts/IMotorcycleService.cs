using NeMobileBg.Common.Models.Motorcycles;

namespace NeMobileBg.Services.Contracts;

public interface IMotorcycleService
{
    Task<string> CreateAsync(MotorcyclesDataModel dataModel, string ownerId);
    Task<MotorcyclesDataModel> GetDetailsAsync(string id);

    Task<IEnumerable<MotorcyclesSearchModel>> GetMotorcyclesSearchDataAsync();

    Task<IEnumerable<MotorcyclesSearchResponseModel>> GetBySearchCriteriaAsync(MotorcyclesSearchModel searchModel);

    Task EditAsync(MotorcyclesDataModel editModel);
    Task DeleteAsync(string id);
}
