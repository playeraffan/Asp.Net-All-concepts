using Microsoft.AspNetCore.Mvc;

namespace Controllers.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
