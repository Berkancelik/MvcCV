using Microsoft.AspNetCore.Mvc;
using MvcCV.EntiyLayer.Concrete;
using MvcCV.Repositories;

namespace MvcCV.Controllers
{
    public class SkillController : Controller
    {

        SkillRepository repo = new SkillRepository();

        public IActionResult Index()
        {
            var skills = repo.List();
            return View(skills);
        }

        [HttpGet]
        public IActionResult SkillAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SkillAdd(Skill p)
        {
            repo.TAdd(p);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult SkillDelete(int id)
        {
            var skill = repo.Find(x => x.Id == id);
            repo.TDelete(skill);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult SkillEdit(int id)
        {
            var skill = repo.Find(x => x.Id == id);
            return View(skill);
        }

        [HttpPost]
        public IActionResult SkillEdit(Skill t)
        {
            var y = repo.Find(x => x.Id == t.Id);
            y.Skills = t.Skills;
            y.Rate = t.Rate;
            repo.TUpdate(y);
            return RedirectToAction("Index");
        }
    }

}
