using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Models.Entities;

namespace KidKinder.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            var values = db.Students.ToList();
            return View(values);
        }

        public ActionResult ParentView(int id)
        {
            var val = db.Parents.Find(id);
            return View("ParentView",val);
        }

        public ActionResult Delete(int id)
        {
            var values = db.Students.Find(id);
            db.Students.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

    }
}