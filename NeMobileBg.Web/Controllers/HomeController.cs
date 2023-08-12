using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Services.Contracts;
using NeMobileBg.Web.Models;
using System.Diagnostics;

namespace NeMobileBg.Web.Controllers;

public class HomeController : Controller
{
    private readonly IHomePageService _homePageService;

    public HomeController(IHomePageService homePageService)
    {
        this._homePageService = homePageService;
    }

    public async Task<IActionResult> Index()
    {
        var vehicles = await this._homePageService.GetHomePageVehicles();

        if (vehicles != null)
        {
            return this.View(vehicles);
        }

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}