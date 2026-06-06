using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirstWebAPI.Controllers
{
    public class DayPlannerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
