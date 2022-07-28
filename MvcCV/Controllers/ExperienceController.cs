using Microsoft.AspNetCore.Mvc;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class ExperienceController : Controller
    {
        ExperienceRepository repo = new ExperienceRepository();
        public IActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }
    }
}
