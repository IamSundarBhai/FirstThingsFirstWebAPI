using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirstWebAPI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
