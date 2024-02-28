using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Models.Entities;


namespace KidKinder.Controllers
{
    
    public class TeacherController : Controller
    {
        // GET: Teacher
        KidKinderContext db = new KidKinderContext();
        public ActionResult TeacherList()
        {
            var values = db.Teachers.ToList();
            return View(values);
        }
         [HttpGet]
        public ActionResult CreateTeacher()
        {
            List<SelectListItem> values = (from x in db.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.BranchName,
                                               Value = x.BranchID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult CreateTeacher(Teacher teach)
        {
            db.Teachers.Add(teach);
            db.SaveChanges();
            return RedirectToAction("TeacherList");
        }


        public ActionResult DeleteTeacher(int id)
        {
            var values = db.Teachers.Find(id);
            db.Teachers.Remove(values);
            db.SaveChanges();
            return RedirectToAction("TeacherList");
        }

        [HttpGet]
        public ActionResult BringTeacher(int id)
        {
            List<SelectListItem> values = (from x in db.Branches.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.BranchName,
                                               Value = x.BranchID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            var value = db.Teachers.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Update(Teacher t)
        {
            var values = db.Teachers.Find(t.TeacherId);
            values.NameSurname = t.NameSurname;
           // values.Title = t.Title;
            values.ImageUrl = t.ImageUrl;
            db.SaveChanges();
            return RedirectToAction("TeacherList");
        }
    }
}