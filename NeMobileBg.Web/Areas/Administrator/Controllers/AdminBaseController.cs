namespace NeMobileBg.Web.Areas.Administrator.Controllers;

[Area(AdminArea)]
[Authorize(Roles = AdminRole)]
public class AdminBaseController : Controller
{
}
