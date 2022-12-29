using Microsoft.AspNetCore.Mvc;

namespace bizland.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class HeroController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
