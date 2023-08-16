namespace NeMobileBg.Web.Controllers;

[Authorize]
public class MotorcyclesController : Controller
{
    private readonly IMotorcycleService _motorcycleService;
    private readonly UserManager<ApplicationUser> _userManager;

    public MotorcyclesController(IMotorcycleService motorcycleService,
                                 UserManager<ApplicationUser> userManager)
    {
        this._motorcycleService = motorcycleService;
        this._userManager = userManager;
    }


    [HttpGet]
    public async Task<IActionResult> Search()
    {
        ViewBag.UserId = this._userManager.GetUserId(User);

        var motorcyclesData = await this._motorcycleService.GetMotorcyclesSearchDataAsync();
        if (motorcyclesData != null)
        {
            return this.View(GetSearchView, motorcyclesData);
        }

        return this.Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Search(MotorcyclesSearchModel searchModel)
    {
        ViewBag.UserId = this._userManager.GetUserId(User);

        var motorcycles = await this._motorcycleService.GetBySearchCriteriaAsync(searchModel);
        if (motorcycles != null)
        {
            return this.View(motorcycles);
        }

        return this.View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return this.View(new MotorcyclesDataModel());
    }

    [HttpPost]
    public async Task<IActionResult> Create(MotorcyclesDataModel motorcycleData)
    {
        var ownerId = this._userManager.GetUserId(User);
        var motorcycleId = await this._motorcycleService.CreateAsync(motorcycleData, ownerId);

        return this.RedirectToAction(DetailsView, new { id = motorcycleId });

    }

    [HttpGet]
    public async Task<IActionResult> Details(string id)
    {
        ViewBag.UserId = this._userManager.GetUserId(User);

        var motorcycle = await this._motorcycleService.GetDetailsAsync(id);
        if (motorcycle != null)
        {
            return this.View(motorcycle);
        }

        return this.View();
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string id)
    {
        var motorcycle = await this._motorcycleService.GetDetailsAsync(id);

        return this.View(motorcycle);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(MotorcyclesDataModel motorcyclesData)
    {

        await this._motorcycleService.EditAsync(motorcyclesData);
        return this.RedirectToAction(DetailsView, new { id = motorcyclesData.Id });
    }

    [HttpGet]
    public async Task<IActionResult> Delete(string id)
    {
        await this._motorcycleService.DeleteAsync(id);

        return this.RedirectToAction(SearchView);
    }
}
