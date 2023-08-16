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
        var result = await this._adminService.GetAllMotorcyclesAsync();
        if (result.Succeeded)
        {
            return this.View(result.Data);
        }

        return this.BadRequest(result.Error);
    }

    public async Task<IActionResult> MyMotorcycles()
    {
        var userId = this._userManager.GetUserId(User);
        var result = await this._adminService.GetMyMotorcyclesAsync(userId);
        if (result.Succeeded)
        {
            return this.View(ViewsConstants.DashboardView, result.Data);
        }

        return this.BadRequest(result.Error);
    }
}
