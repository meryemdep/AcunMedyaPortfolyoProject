using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities(); 
        public ActionResult Index()
        {
            var values = db.Skills.ToList();    
            return View(values);
        }
        public ActionResult DeleteSkills(int id)
        {
            var values = db.Skills.Find(id);
            db.Skills.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateSkills()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkills(Skills skills)
        {
            db.Skills.Add(skills);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}