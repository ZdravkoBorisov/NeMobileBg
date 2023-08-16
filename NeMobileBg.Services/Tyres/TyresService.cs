
namespace NeMobileBg.Services.Tyres;

public class TyresService : ITyresService
{
    private readonly IRepository _repository;

    public TyresService(IRepository repository)
    {
        this._repository = repository;
    }
}
