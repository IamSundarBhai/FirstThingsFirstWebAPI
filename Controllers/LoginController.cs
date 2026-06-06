using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirstWebAPI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
