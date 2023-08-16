namespace NeMobileBg.Web.Areas.Administrator.Controllers;

public class HomeController : AdminBaseController
{
    public IActionResult Index()
    {
        return this.View();
    }
}
