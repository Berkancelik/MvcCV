using Microsoft.AspNetCore.Mvc;

namespace MvcCV.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
