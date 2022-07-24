using Microsoft.AspNetCore.Mvc;
using MvcCV.Models
namespace MvcCV.Controllers
{
    public class DefaultController : Controller
    {
        DbCvContext dbCvContext;
        public IActionResult Index()
        {
            return View();
        }
    }
}
