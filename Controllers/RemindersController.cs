using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirstWebAPI.Controllers
{
    public class RemindersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
