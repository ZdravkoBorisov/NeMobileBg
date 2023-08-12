using NeMobileBg.Data.Models;
using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Services.Trucks;

public class TrucksService : ITrucksService
{
    private readonly IRepository _repository;

    public TrucksService(IRepository repository)
    {
        this._repository = repository;
    }
}
