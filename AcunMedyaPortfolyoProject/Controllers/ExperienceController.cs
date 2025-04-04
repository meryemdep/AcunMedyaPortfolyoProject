using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class ExperienceController : Controller
    {
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities(); 
        // GET: Experience
        public ActionResult Index()
        {
            var value = db.Experience.ToList(); 
            return View(value);
        }
        public ActionResult DeleteExperience(int id)
        {
            var values = db.Experience.Find(id);
            db.Experience.Remove(values);
            db.SaveChanges();   
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExperience(Experience experience)
        {
            db.Experience.Add(experience);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}