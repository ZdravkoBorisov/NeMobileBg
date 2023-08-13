using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Common.Models.Motorcycles;

namespace NeMobileBg.Services.Contracts;

public interface IUsersService
{
    Task<IEnumerable<CarsDataModel>> GetCars(string userId);

    Task<IEnumerable<MotorcyclesDataModel>> GetMotorcycles(string userId);
}
