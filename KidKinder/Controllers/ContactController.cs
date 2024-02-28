using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Models.Entities;

namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        // GET: Contact
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult partialContactHeader()
        {
            return PartialView();
        }

        public PartialViewResult partialContactAdress()
        {
            ViewBag.description = db.Communications.Select(x => x.Description).FirstOrDefault();
            ViewBag.phone = db.Communications.Select(x => x.Phone).FirstOrDefault();
            ViewBag.address = db.Communications.Select(x => x.Address).FirstOrDefault();
            ViewBag.email = db.Communications.Select(x => x.Email).FirstOrDefault();
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult partialSupport()
        {
            ViewBag.Now = DateTime.Now.ToString("dd.MM.yyyy");
            return PartialView();
        }
        [HttpPost]
        public ActionResult Create(Contact p)
        { 
            db.Contacts.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}