using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

public class CarsController : Controller
{
    private readonly ICarsService _carsService;

    public CarsController(ICarsService carsService)
    {
        this._carsService = carsService;
    }
}
