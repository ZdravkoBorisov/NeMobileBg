using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Services.Motorcycles;

public class MotorcyclesService : IMotorcycleService
{
    private readonly IRepository _repository;

    public MotorcyclesService(IRepository repository)
    {
        this._repository = repository;
    }
}
