using Microsoft.AspNetCore.Mvc;

namespace MvcCV.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
