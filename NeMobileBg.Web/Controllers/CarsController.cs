using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Data.Models;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

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
            return this.View("GetSearch", carsData);
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

        return  this.View(car);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(CarsDataModel car)
    {
        if (this.ModelState.IsValid)
        {
            await this._carsService.EditAsync(car);
            return this.RedirectToAction("Details", new { id = car.Id });
        }

        return this.View(car);
    }

}
