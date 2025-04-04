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
    }
}