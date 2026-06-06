using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirstWebAPI.Controllers
{
    public class HabitTrackingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
