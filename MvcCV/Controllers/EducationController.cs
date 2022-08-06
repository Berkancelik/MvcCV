using Microsoft.AspNetCore.Mvc;
using MvcCV.EntiyLayer.Concrete;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class EducationController : Controller
    {
        GenericRepository<Education> repo = new GenericRepository<Education>();
        public IActionResult Index()
        {
            var values = repo.List();
            return View(values);
        }

        [HttpGet]
        public IActionResult EducationAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EducationAdd(Education p)
        {
            

            repo.TAdd(p);
            return RedirectToAction("Index");

        }

    }
}
