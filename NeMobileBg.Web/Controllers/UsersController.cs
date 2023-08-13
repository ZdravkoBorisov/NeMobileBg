using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Data.Models;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

[Authorize]
public class UsersController : Controller
{
    private readonly IUsersService _usersService;
    private readonly UserManager<ApplicationUser> _userManager;

    public UsersController(IUsersService usersService,
                           UserManager<ApplicationUser> userManager)
    {
        this._usersService = usersService;
        this._userManager = userManager;
    }

    [HttpGet]
    public async Task<IActionResult> Cars()
    {
        var userId = this._userManager.GetUserId(User);
        var cars = await this._usersService.GetCars(userId);

        return this.View(cars);
    }

    [HttpGet]
    public async Task<IActionResult> Motorcycles()
    {
        var userId = this._userManager.GetUserId(User);
        var motorcycles = await this._usersService.GetMotorcycles(userId);

        return this.View(motorcycles);
    }
}
