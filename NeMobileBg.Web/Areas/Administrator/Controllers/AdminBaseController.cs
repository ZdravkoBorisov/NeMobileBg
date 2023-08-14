using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NeMobileBg.Web.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "admin")]
    public class AdminBaseController : Controller
    {
    }
}
