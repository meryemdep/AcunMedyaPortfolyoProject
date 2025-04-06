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
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.Projectpart.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateProject(Projectpart model)
        {
            var value = db.Projectpart.Find(model.ProjectID);
            value.ProjectName = model.ProjectName;  
            value.Description = model.Description;  
            value.ProjectLink = model.ProjectLink;  
            value.Image1 = model.Image1;
            value.Image2 = model.Image2;
            value.Image3 = model.Image3;
            value.CategoryID = model.CategoryID;    
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}