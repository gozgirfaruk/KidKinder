using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Models.Entities;
using System.Web.Routing;

namespace KidKinder.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message

        KidKinderContext db = new KidKinderContext();
        Contact cont = new Contact();
      
        public ActionResult InBox()
        {
            var values = db.Contacts.OrderBy(x => x.SendDate).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Listener()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult Listener(SendMess p)
        {
            db.sendMesses.Add(p);
            db.SaveChanges();
            return RedirectToAction("InBox");
        }
        [HttpGet]
        public PartialViewResult partialBring(int id)
        {
            var values = db.Contacts.Find(id);
            return PartialView(values);
        }

        public PartialViewResult partialCreate()
        {
          
            return PartialView();
        }


        public ActionResult OutBox()
        {
            var values = db.sendMesses.ToList();
            return View(values);
        }
    
        public ActionResult SubsBox()
        {
            var values = db.MailSubscribes.ToList();
            return View(values);
        }

        public ActionResult Delete(int id)
        {
            var values = db.Contacts.Find(id);
            db.Contacts.Remove(values);
            db.SaveChanges();
            return RedirectToAction("AllBox");
        }
    }
}