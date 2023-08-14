using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Data.Models;
using NeMobileBg.Web.Areas.Administrator.Services.Contracts;

namespace NeMobileBg.Web.Areas.Administrator.Controllers;

public class MotorcyclesController : AdminBaseController
{
    private readonly IAdminService _adminService;
    private readonly UserManager<ApplicationUser> _userManager;

    public MotorcyclesController(IAdminService adminService,
                                 UserManager<ApplicationUser> userManager)
    {
        this._adminService = adminService;
        this._userManager = userManager;
    }

    public async Task<IActionResult> Dashboard()
    {
        var motorcycles = await this._adminService.GetAllMotorcyclesAsync();

        return this.View(motorcycles);
    }

    public async Task<IActionResult> MyMotorcycles()
    {
        var userId = this._userManager.GetUserId(User);
        var motorcycles = await this._adminService.GetMyMotorcyclesAsync(userId);

        return this.View(motorcycles);
    }
}
