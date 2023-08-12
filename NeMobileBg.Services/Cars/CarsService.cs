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
}
