using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Common.Models.Motorcycles;

namespace NeMobileBg.Services.Contracts;

public interface IUsersService
{
    Task<IEnumerable<CarsDataModel>> GetAllCarsAsync();
    Task<IEnumerable<CarsDataModel>> GetMyCarsAsync(string userId);
    Task<IEnumerable<MotorcyclesDataModel>> GetAllMotorcyclesAsync();
    Task<IEnumerable<MotorcyclesDataModel>> GetMyMotorcyclesASync(string userId);
}
