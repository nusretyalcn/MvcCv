using MvcCv.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcCv.Controllers
{
    public class ExperienceController : Controller
    {
       //get: experience
        ExperienceRepository _experienceRepository;

        public ExperienceController(ExperienceRepository experienceRepository)
        {
            _experienceRepository = experienceRepository;
        }

        // ExperienceRepository repository = new ExperienceRepository();

        public ActionResult Index()
        {
            
            return View(_experienceRepository.GetAll());
        }
    }
}