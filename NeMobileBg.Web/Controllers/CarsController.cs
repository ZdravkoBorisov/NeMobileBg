using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Common.Models.Cars;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

public class CarsController : Controller
{
    private readonly ICarsService _carsService;

    public CarsController(ICarsService carsService)
    {
        this._carsService = carsService;
    }


    [HttpGet]
    public async Task<IActionResult> Search()
    {
        var carsData = await this._carsService.GetCarsSearchData();
        if (carsData != null)
        {
            return this.View("GetSearch", carsData);
        }

        return this.Ok();
    }

    [HttpPost]
    public async Task<IActionResult> Search(CarsSearchModel searchModel)
    {
        var cars = await this._carsService.GetBySearchCriteria(searchModel);
        if (cars != null)
        {
            return this.View(cars);
        }

        return this.View();
    }
}
