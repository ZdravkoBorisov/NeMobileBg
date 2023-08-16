namespace NeMobileBg.Web.Controllers;

[Authorize]
public class TyresController : Controller
{
    private readonly ITyresService _tyresService;

    public TyresController(ITyresService tyresService)
    {
        this._tyresService = tyresService;
    }
}
