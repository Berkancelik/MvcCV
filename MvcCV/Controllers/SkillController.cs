using DataAccessLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using MvcCV.DataAccessLayer.Concrete;
using MvcCV.EntiyLayer.Concrete;
using System.Linq;

namespace MvcCV.Controllers
{
    public class SkillController : Controller
    {

        GenericRepository<Skill> repo = new GenericRepository<Skill>();

        public IActionResult Index()
        {
            var skills = repo.GetListAll();
            return View(skills);
        }

        public IActionResult SkillAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SkillAdd(Skill p)
        {
            repo.Insert(p);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult SkillDelete(int id)
        {
            var skill = repo.GetListAll(x => x.Id == id);
            repo.Delete(skill);
            return RedirectToAction("Index");
        }
    }

}
