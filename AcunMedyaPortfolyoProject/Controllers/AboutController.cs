using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities();
        public ActionResult Index()
        {
            var values = db.About.ToList(); 
            return View(values);
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db.About.Find(id);
            db.About.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            db.About.Add(about);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}