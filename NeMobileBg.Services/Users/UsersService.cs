using NeMobileBg.Data.Repository;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Services.Users;

public class UsersService : IUsersService
{
    private readonly IRepository _repository;

    public UsersService(IRepository repository)
    {
        this._repository = repository;
    }
}
