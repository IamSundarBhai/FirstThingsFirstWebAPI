using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirstWebAPI.Controllers
{
    public class InsightsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
