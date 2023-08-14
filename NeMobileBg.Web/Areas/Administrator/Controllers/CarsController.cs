using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Data.Models;
using NeMobileBg.Services.Contracts;
using NeMobileBg.Web.Areas.Administrator.Services.Contracts;

namespace NeMobileBg.Web.Areas.Administrator.Controllers;

public class CarsController : AdminBaseController
{
    private readonly IAdminService _adminService;
    private readonly UserManager<ApplicationUser> _userManager;

    public CarsController(IAdminService adminService,
                         UserManager<ApplicationUser> userManager)
    {
        this._adminService = adminService;
        this._userManager = userManager;
    }

    public async Task<IActionResult> Dashboard()
    {
        var cars = await this._adminService.GetAllCarsAsync();
        return this.View(cars);
    }

    public async Task<IActionResult> MyCars()
    {
        var userId = this._userManager.GetUserId(User);
        var cars = await this._adminService.GetMyCarsAsync(userId);

        return this.View("Dashboard", cars);
    }

}
