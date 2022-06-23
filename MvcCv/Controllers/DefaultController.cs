using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv.Models.Entity;

namespace MvcCv.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DbCvEntities db = new DbCvEntities();
        public ActionResult Index()
        {
            var values = db.Abouts.ToList();
            return View(values);
        }
        public PartialViewResult Experiences()
        {
            var experience = db.Experiences.ToList();
            return PartialView(experience);
        }

        public PartialViewResult Educations()
        {
            var education = db.Educations.ToList();
            return PartialView(education);
        }

        public PartialViewResult Skills()
        {
            var skill = db.Skills.ToList();
            return PartialView(skill);
        }

        public PartialViewResult Hobbies()
        {
            var hobby = db.Hobbies.ToList();
            return PartialView(hobby);
        }

        public PartialViewResult Awards()
        {
            var award = db.Awards.ToList();
            return PartialView(award);
        }

        [HttpGet]
        public PartialViewResult Contacts()
        {
            var contact = db.Contacts.ToList();
            return PartialView(contact);
        }
        [HttpPost]
        public PartialViewResult Contacts(Contacts t)
        {
            t.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            db.Contacts.Add(t);
            db.SaveChanges();
            return PartialView();
        }
    }
}