using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities(); 
        public ActionResult Index()
        {
            var values = db.Projectpart.ToList();   
            return View(values);
        }
        public ActionResult DeleteProject(int id)
        {
            var values = db.Projectpart.Find(id);
            db.Projectpart.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index"); 
        }
        [HttpGet]
        public ActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(Projectpart projectpart)
        {
            db.Projectpart.Add(projectpart);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}