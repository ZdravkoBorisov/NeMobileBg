using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Data.Models;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

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

        var carsData = await this._motorcycleService.GetMotorcyclesSearchDataAsync();
        if (carsData != null)
        {
            return this.View("GetSearch", carsData);
        }

        return this.Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Search(MotorcyclesSearchModel searchModel)
    {
        ViewBag.UserId = this._userManager.GetUserId(User);

        var cars = await this._motorcycleService.GetBySearchCriteriaAsync(searchModel);
        if (cars != null)
        {
            return this.View(cars);
        }

        return this.View();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return this.View(new MotorcyclesDataModel());
    }

    [HttpPost]
    public async Task<IActionResult> Create(MotorcyclesDataModel car)
    {
        var ownerId = this._userManager.GetUserId(User);
        var carId = await this._motorcycleService.CreateAsync(car, ownerId);

        return this.RedirectToAction("Details", new { id = carId });

    }

    [HttpGet]
    public async Task<IActionResult> Details(string id)
    {
        ViewBag.UserId = this._userManager.GetUserId(User);

        var car = await this._motorcycleService.GetDetailsAsync(id);
        if (car != null)
        {
            return this.View(car);
        }

        return this.View();
    }

    [HttpGet]
    public async Task<IActionResult> Edit(string id)
    {
        var car = await this._motorcycleService.GetDetailsAsync(id);

        return this.View(car);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(MotorcyclesDataModel car)
    {

        await this._motorcycleService.EditAsync(car);
        return this.RedirectToAction("Details", new { id = car.Id });
    }

    [HttpGet]
    public async Task<IActionResult> Delete(string id)
    {
        await this._motorcycleService.DeleteAsync(id);

        return this.RedirectToAction("Search");
    }
}
