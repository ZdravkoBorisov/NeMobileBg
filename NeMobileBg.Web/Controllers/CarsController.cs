namespace NeMobileBg.Web.Controllers;

[Authorize]
public class CarsController : Controller
{
    private readonly ICarsService _carsService;
    private readonly UserManager<ApplicationUser> _userManager;

    public CarsController(ICarsService carsService,
                          UserManager<ApplicationUser> userManager)
    {
        this._carsService = carsService;
        this._userManager = userManager;
    }


    [HttpGet]
    public async Task<IActionResult> Search()
    {
        ViewBag.UserId = this._userManager.GetUserId(User);

        var carsData = await this._carsService.GetCarsSearchDataAsync();
        if (carsData != null)
        {
            return this.View(GetSearchView, carsData);
        }

        return this.Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Search(CarsSearchModel searchModel)
    {
        ViewBag.UserId = this._userManager.GetUserId(User);

        var cars = await this._carsService.GetBySearchCriteriaAsync(searchModel);
        if (cars != null)
        {
            return this.View(cars);
        }

        return this.View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return this.View(new CarsDataModel());
    }

    [HttpPost]
    public async Task<IActionResult> Create(CarsDataModel car)
    {
        var ownerId = this._userManager.GetUserId(User);
        var carId = await this._carsService.CreateAsync(car, ownerId);

        return this.RedirectToAction(ViewsConstants.DetailsView, new { id = carId });

    }

    [HttpGet]
    public async Task<IActionResult> Details(string id)
    {
        ViewBag.UserId = this._userManager.GetUserId(User);

        var car = await this._carsService.GetDetailsAsync(id);
        if (car != null)
        {
            return this.View(car);
        }

        return this.View();
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string id)
    {
        var car = await this._carsService.GetDetailsAsync(id);

        return this.View(car);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(CarsDataModel car)
    {

        await this._carsService.EditAsync(car);
        return this.RedirectToAction(DetailsView, new { id = car.Id });
    }

    [HttpGet]
    public async Task<IActionResult> Delete(string id)
    {
        await this._carsService.Delete(id);
        if (this.User.IsInRole(AdminRole))
        {
            return RedirectToAction(IndexView, HomeView, new { Area = AdminArea });
        }

        return this.RedirectToAction(SearchView);
    }

}
