using Microsoft.AspNetCore.Mvc;
using MvcCV.EntiyLayer.Concrete;
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

        [HttpGet]
        public ActionResult AddExperience()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddExperience(Experience p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }
    }
}
