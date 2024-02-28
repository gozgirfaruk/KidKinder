using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;
using KidKinder.Models.Entities;

namespace KidKinder.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        KidKinderContext db = new KidKinderContext();
        public ActionResult Home()
        {
            var values = db.Galleries.ToList();
            return View(values);
        }

        public ActionResult Forward(int id)
        {
            var values = db.Galleries.Find(id);
            
                values.Status = 0;
                db.SaveChanges();
                return RedirectToAction("Home");
           
        }

        public ActionResult Back(int id)
        {
            var values = db.Galleries.Find(id);
            values.Status = 1;
            db.SaveChanges();
            return RedirectToAction("Home");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(Gallery p)
        {
            db.Galleries.Add(p);
            db.SaveChanges();
            return RedirectToAction("Home");

        }

        public ActionResult Delete(int id)
        {
            var values = db.Galleries.Find(id);
            db.Galleries.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Home");
            
        }


    }
}