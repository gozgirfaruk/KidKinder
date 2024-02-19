using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class ParentController : Controller
    {
        // GET: Parent
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            var values = db.Parents.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Parent p)
        {
            db.Parents.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult BringParent(int id)
        {
            var values = db.Parents.Find(id);
            return View("BringParent",values);
        }

        [HttpPost]
        public ActionResult Update(Parent p)
        {
            var values = db.Parents.Find(p.ParentID);
            values.FirstName = p.FirstName;
            values.LastName = p.LastName;
            values.Email = p.Email;
            values.PhoneNumber = p.PhoneNumber;
            values.Address = p.Address;
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var values = db.Parents.Find(id);
            db.Parents.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}