using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class ContactsController : Controller
    {
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities();
        // GET: Contacts
        public ActionResult Index()
        {
            var model = db.Contacts.ToList();
            return View(model);
        }
        public ActionResult DeleteContacts (int id)
        {
            var values = db.Contacts.Find(id);
            db.Contacts.Remove(values); 
            db.SaveChanges(); 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult CreateContacts()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateContacts (Contacts contacts)
        {
            db.Contacts.Add(contacts);
            db.SaveChanges();   
            return RedirectToAction("Index");  
        }
        [HttpGet]
        public ActionResult UpdateContacts(int id)
        {
            var values = db.Contacts.Find(id);
            return View(values);
        
        }
        [HttpPost]
        public ActionResult UpdateContacts(Contacts model)
        {
            var value = db.Contacts.Find(model.ContactID); 
            value.Description = model.Description;
            value.Adress = model.Adress;
            value.Email = model.Email;
            value.Phone = model.Phone;
            db.SaveChanges();
            return RedirectToAction("Index");

        }



    }
}