using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities();
        public ActionResult Index()
        {
            var values = db.CategoryTbl.ToList();
            return View(values);
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.CategoryTbl.Find(id);
            db.CategoryTbl.Remove(values);
            db.SaveChanges(); 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]

        public ActionResult CreateCategory(CategoryTbl category)
        {
            db.CategoryTbl.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.CategoryTbl.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(CategoryTbl model)
        {
            var value = db.CategoryTbl.Find(model.CategoryID);
            value.CategoryName = model.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");

        }

    }
}