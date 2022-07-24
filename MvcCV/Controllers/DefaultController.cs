﻿using Microsoft.AspNetCore.Mvc;
using MvcCV.Models.Entity;
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
            var educations = db.Experiences.ToList();
            return PartialView(educations);
        }
    }
}
