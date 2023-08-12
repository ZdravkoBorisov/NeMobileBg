using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

public class MotorcyclesController : Controller
{
    private readonly IMotorcycleService _motorcycleService;

    public MotorcyclesController(IMotorcycleService motorcycleService)
    {
        this._motorcycleService = motorcycleService;
    }
}
