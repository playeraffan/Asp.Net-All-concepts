using Atributal_Routing.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Atributal_Routing.Controllers.Method1
{
    [Route("Home")]  //if we write controller name here here we will not need to write in routing
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("/Index")]

        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        [Route("About/Affan/Zia")]
        public IActionResult About()
        {
            return View();
        }

        //Routing with Id
        [Route("Details/{id}")]  //it won't work If we don't provide id 
        public int Details(int id)
        {
            return id;
        }

        [Route("Details/{id?}")]  //it will work even If we don't provide id (? this sign is nullabe sign will make it optional)
        public int Details(int? id)
        {
            return id ?? 420; //?? it is Null-Coalescing Operator it will display if id is null.
        }
    }
}




namespace Atributal_Routing.Another.method2
{
    [Route("[Controller]")]  //if we write controller name here here we will not need to write in routing
    public class HomeController : Controller
    {

        [Route("[Action]")]
        public IActionResult product()
        {
            return View();
        }
        //Routing with Id
        [Route("[Action]/{id}")]
        public int Detail(int id)
        {
            return id;
        }
    }
}


namespace Atributal_Routing.Another.method3
{
    [Route("[Controller]/[Action]")]  //if we write controller name here here we will not need to write in routing
    public class HomeController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }

        //Routing with Id
        [Route("{id?}")]
        public int detail(int? id)
        {
            return id ?? 430;
        }
    }
}

