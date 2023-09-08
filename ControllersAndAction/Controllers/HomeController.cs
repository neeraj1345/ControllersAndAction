using Microsoft.AspNetCore.Mvc;

namespace ControllersAndAction.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public string Display()
        {
            return "this is my first web side using Routing , Controllers , Action Method , View";
        }
        public int DisplayaId(int id)
        {
            return id;
        }
    }
    
}
