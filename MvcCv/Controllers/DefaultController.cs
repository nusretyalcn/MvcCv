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
    }
}