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
        var result = await this._adminService.GetAllCarsAsync();
        if (result.Succeeded)
        {
            return this.View(result.Data);
        }

        return this.BadRequest(result.Error);
    }

    public async Task<IActionResult> MyCars()
    {
        var userId = this._userManager.GetUserId(User);
        var result = await this._adminService.GetMyCarsAsync(userId);

        if (result.Succeeded)
        {
            return this.View(ViewsConstants.DashboardView, result.Data);
        }

        return this.BadRequest(result.Error);
    }
}
