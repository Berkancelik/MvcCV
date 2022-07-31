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
    }
}
