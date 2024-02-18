using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;
using System.Web.Routing;

namespace KidKinder.Controllers
{
    public class ClassesController : Controller
    {
        // GET: Classes
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            var values = db.ClassRooms.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewClass(ClassRoom p)
        {
            db.ClassRooms.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DetailClasses()
        {
            var values = db.ClassRooms.ToList();
            return View(values);
        }

        public ActionResult Delete(int id)
        {
            var values = db.ClassRooms.Find(id);
            db.ClassRooms.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult BringClass(int id)
        {
            var values = db.ClassRooms.Find(id);
            return View("BringClass", values);

        }
        [HttpPost]
        public ActionResult UpdateClass(ClassRoom p)
        {
            var values = db.ClassRooms.Find(p.ClassRoomId);
            values.Title = p.Title;
            values.Description = p.Description;
            values.AgeOfKids = p.AgeOfKids;
            values.TotalSeat = p.TotalSeat;
            values.ClassTime = p.ClassTime;
            values.Price = p.Price;
            values.ImageUrl = p.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
       
    }
}