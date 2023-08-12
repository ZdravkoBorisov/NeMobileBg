using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

public class TrucksController : Controller
{
    private readonly ITrucksService _trucksService;

    public TrucksController(ITrucksService trucksService)
    {
        this._trucksService = trucksService;
    }
}
