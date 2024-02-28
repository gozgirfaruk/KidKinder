using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            var values = db.Testimonials.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            var value = db.Testimonials.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult Update(Testimonial p)
        {
            db.Testimonials.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Delete(int id)
        {
            var values = db.Testimonials.Find(id);
            db.Testimonials.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}