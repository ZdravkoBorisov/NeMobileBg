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
        var result = await this._usersService.GetMyCarsAsync(userId);
        if (result.Succeeded)
        {
            return this.View(result.Data);
        }

        return this.BadRequest(result.Error);
    }

    [HttpGet]
    public async Task<IActionResult> Motorcycles()
    {
        var userId = this._userManager.GetUserId(User);
        var result = await this._usersService.GetMyMotorcyclesASync(userId);
        if (result.Succeeded)
        {
              return this.View(result.Data);
        }

        return this.BadRequest(result.Error);
    }
}
