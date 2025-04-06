using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialMenu()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialSlider1()
        {
            var values = db.Slider1.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialAbout()
        {
            var abouts = db.About.ToList();
            return PartialView(abouts);
        }
        public PartialViewResult PartialSkills()
        {
            var skill = db.Skills.ToList();
            return PartialView(skill);
        }
        public PartialViewResult PartialSummary()
        {
            var abouts = db.About.ToList();
            return PartialView(abouts);
        }
        public PartialViewResult PartialEducation()
        {
            var edu = db.Education.ToList();
            return PartialView(edu);
        }
        public PartialViewResult PartialExperience()
        {
            var job = db.Experience.ToList();
            return PartialView(job);
        }
        public PartialViewResult PartialServices()
        {
            var service = db.ServicesPart.ToList();
            return PartialView(service);
        }
        public PartialViewResult PartialProjects()
        {
            var project = db.Projectpart.ToList();
            return PartialView(project);
        }

        public PartialViewResult PartialReferences()
        {
            var values = db.References.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialContact() 
        {
            var x = db.Contacts.ToList();
            return PartialView(x);  
        }
        public ActionResult PartialMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult PartialMessage(Message message) 
        {
            db.Message.Add(message);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        //view -- partialview
    }
}