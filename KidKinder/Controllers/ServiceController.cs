using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            var values = db.Services.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Created(Service service)
        {
            db.Services.Add(service);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var values = db.Services.Find(id);
            db.Services.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult BringService(int id)
        {
            var values = db.Services.Find(id);
            return View("BringService",values);
        }

        public ActionResult UpdateService(Service service)
        {
            var values = db.Services.Find(service.ServiceId);
            values.Title = service.Title;
            values.Description = service.Description;
            values.IconUrl = service.IconUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}