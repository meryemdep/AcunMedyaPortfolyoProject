using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Services
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities();
        public ActionResult Index()
        {
            var values = db.ServicesPart.ToList();  
            return View(values);
        }
        public ActionResult DeleteServices(int id)
        {
            var values = db.ServicesPart.Find(id);    
            db.ServicesPart.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateServices(ServicesPart services)
        {
            db.ServicesPart.Add(services);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}