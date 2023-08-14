using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Common.Models.Motorcycles;

namespace NeMobileBg.Web.Areas.Administrator.Services.Contracts;

public interface IAdminService
{
    Task<IEnumerable<CarsDataModel>> GetMyCarsAsync(string adminId);
    Task<IEnumerable<CarsDataModel>> GetAllCarsAsync();
    Task<IEnumerable<MotorcyclesDataModel>> GetMyMotorcyclesAsync(string adminId);
    Task<IEnumerable<MotorcyclesDataModel>> GetAllMotorcyclesAsync();

}
