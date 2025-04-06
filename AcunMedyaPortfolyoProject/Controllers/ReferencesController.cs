using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class ReferencesController : Controller
    {
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities();
        // GET: References
        public ActionResult Index()
        {
            var values = db.References.ToList();
            return View(values);
        }
        public ActionResult DeleteReferences(int id)
        {
            var values = db.References.Find(id);
            db.References.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }
        [HttpGet]
        public ActionResult CreateReferences()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateReferences(References references)
        {
            db.References.Add(references);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateReferences(int id)
        {
            var values = db.References.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateReferences(References model)
        {
            var value = db.References.Find(model.ReferenceID);
            value.Description1 = model.Description1;
            value.ReferenceName = model.ReferenceName; 
            value.Description2 = model.Description2;  
            value.ImageUrl = model.ImageUrl;
            value.Title = model.Title;  
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}