using NeMobileBg.Common;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Common.Models.Motorcycles;

namespace NeMobileBg.Services.Contracts;

public interface IUsersService
{
    Task<Result<IEnumerable<CarsDataModel>>> GetAllCarsAsync();
    Task<Result<IEnumerable<CarsDataModel>>> GetMyCarsAsync(string userId);
    Task<Result<IEnumerable<MotorcyclesDataModel>>> GetAllMotorcyclesAsync();
    Task<Result<IEnumerable<MotorcyclesDataModel>>> GetMyMotorcyclesASync(string userId);
}
