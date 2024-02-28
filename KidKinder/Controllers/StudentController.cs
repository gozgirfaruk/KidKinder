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
        [HttpPost]
        public ActionResult Create(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult BringStudent(int id)
        {
            var values = db.Students.Find(id);
            return View("BringStudent", values);
        }

        [HttpPost]
        public ActionResult Update(Student student)
        {
            var values = db.Students.Find(student.ParentID);
            values.FirstName = student.FirstName;
            values.LastName = student.LastName;
            values.BirthDay = student.BirthDay;
            values.ParentID = student.ParentID;
            values.Status = student.Status;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}