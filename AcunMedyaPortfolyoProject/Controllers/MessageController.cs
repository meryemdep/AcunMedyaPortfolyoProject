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
    }
}