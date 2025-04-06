using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    
    public class StatisticsController : Controller
    {
        // GET: Statistics
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities(); 
        public ActionResult Index()
        {
            ViewBag.CategoryCount = db.CategoryTbl.Count();
            ViewBag.SkillsCount = db.Skills.Count();
            ViewBag.MessagesCount = db.Message.Count();
            ViewBag.ProjectsCount = db.Projectpart.Count();
            ViewBag.ReferencesCount = db.References.Count();



            return View();
        }
    }
}