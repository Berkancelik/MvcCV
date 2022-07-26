using Microsoft.AspNetCore.Mvc;
using MvcCV.DataAccessLayer.Concrete;
using MvcCV.EntiyLayer.Concrete;
using System;
using System.Linq;

namespace MvcCV.Controllers
{
    public class DefaultController : Controller
    {
        DbCvContext db = new DbCvContext();
        public IActionResult Index()
        {
            var values = db.Abouts.ToList();
            return View(values);
        }

        public PartialViewResult Experience()
        {
            var experiences = db.Experiences.ToList();
            return PartialView(experiences);
        }

        public PartialViewResult Educations()
        {
            var educations = db.Educations.ToList();
            return PartialView(educations);
        }

        public PartialViewResult Skills()
        {
            var skills = db.Skills.ToList();
            return PartialView(skills);
        }

        public PartialViewResult Hobbies()
        {
            var hobbies = db.Hobbies.ToList();
            return PartialView(hobbies);
        }

        public PartialViewResult Certificates()
        {
            var certificates = db.Certificates.ToList();
            return PartialView(certificates);
        }

        [HttpGet]
        public PartialViewResult Contact()
        {
            var contact = db.Contacts.ToList();
            return PartialView(contact);
        }

        [HttpPost]
        public PartialViewResult Contact(Contact t)
        {
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Contacts.Add(t);
            db.SaveChanges();
            return PartialView();
        }



    }
}
