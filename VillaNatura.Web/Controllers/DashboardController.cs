using Microsoft.AspNetCore.Mvc;

namespace VillaNatura.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
