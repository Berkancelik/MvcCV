using Microsoft.AspNetCore.Mvc;

namespace MvcCV.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
