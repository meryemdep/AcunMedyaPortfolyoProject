using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyoProject.Models;

namespace AcunMedyaPortfolyoProject.Controllers
{
    public class MessageController : Controller
    {
        DBacunmedyaproject1Entities db = new DBacunmedyaproject1Entities();
        // GET: Message
        public ActionResult Index()
        {
            var values = db.Message.ToList();
            return View(values);
        }
        public ActionResult DeleteMessage(int id)
        {
            var values = db.Message.Find(id);
            db.Message.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult UpdateMessage(int id)
        {
            var values = db.Message.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateMessage(Message message)
        {
            var value = db.Message.Find(message.MessageID);
            value.NameSurname = message.NameSurname;
            value.Mail = message.Mail;
            value.Subject = message.Subject;    
            value.MessageContent = message.MessageContent;
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}