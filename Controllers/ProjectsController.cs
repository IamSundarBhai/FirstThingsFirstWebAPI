using Microsoft.AspNetCore.Mvc;

namespace FirstThingsFirstWebAPI.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
