using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class EducationController : Controller
    {
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities();
        // GET: Education

        public ActionResult Index()
        {
            var values = db.Education.ToList();
            return View(values);
        }
        public ActionResult DeleteEducation(int id)
        {
            var values = db.Education.Find(id);
            db.Education.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateEducation(Education education)
        {
            db.Education.Add(education);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var values = db.Education.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateEducation(Education model)
        {
            var value = db.Education.Find(model.EducationID);
            value.StartYear = model.StartYear;
            value.EndYear = model.EndYear;
            value.Name = model.Name;    
            value.Description  = model.Description; 
            value.Major = model.Major; 
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}