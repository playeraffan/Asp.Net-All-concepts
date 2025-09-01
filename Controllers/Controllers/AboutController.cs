using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
