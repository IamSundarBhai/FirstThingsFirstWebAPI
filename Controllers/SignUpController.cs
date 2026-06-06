using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirstWebAPI.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
