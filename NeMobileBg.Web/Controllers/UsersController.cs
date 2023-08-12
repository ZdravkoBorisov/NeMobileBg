using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

public class UsersController : Controller
{
    private readonly IUsersService _usersService;

    public UsersController(IUsersService usersService)
    {
        this._usersService = usersService;
    }
}
