using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            var values = db.Admins.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Admin p)
        {
            db.Admins.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var values = db.Admins.Find(id);
            db.Admins.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            var values = db.Admins.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult Update(Admin p)
        {
            var values = db.Admins.Find(p.AdminId);
            values.Username = p.Username;
            values.Password = p.Password;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}