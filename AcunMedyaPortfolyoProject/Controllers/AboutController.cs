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
        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var values = db.About.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = db.About.Find(about.AboutID);
            value.ImageUrl = about.ImageUrl;
            value.Title = about.Title;
            value.BirthDay = about.BirthDay;
            value.Age = about.Age;  
            value.Degree = about.Degree;    
            value.Freelance = about.Freelance;  
            value.Email = about.Email;  
            value.Phone = about.Phone;
            value.City = about.City;
            value.Decription1 = about.Decription1;
            value.Decription2 = about.Decription2;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }

}