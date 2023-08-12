using Microsoft.AspNetCore.Mvc;
using NeMobileBg.Services.Contracts;

namespace NeMobileBg.Web.Controllers;

public class TyresController : Controller
{
    private readonly ITyresService _tyresService;

    public TyresController(ITyresService tyresService)
    {
        this._tyresService = tyresService;
    }
}
