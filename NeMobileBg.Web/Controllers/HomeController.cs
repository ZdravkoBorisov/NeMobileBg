using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Data.Models;
using NeMobileBg.Services.Contracts;
using NeMobileBg.Web.Models;
using System.Diagnostics;

namespace NeMobileBg.Web.Controllers;

public class HomeController : Controller
{
    private readonly IHomePageService _homePageService;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(IHomePageService homePageService,
                          UserManager<ApplicationUser> userManager)
    {
        this._homePageService = homePageService;
        this._userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {

        if (this.User.IsInRole("admin"))
        {
            return RedirectToAction("Index", "Home", new { Area = "Administrator" });
        }
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