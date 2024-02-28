using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class GoogleChartController : Controller
    {
        // GET: GoogleChart
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            ViewBag.a = db.Testimonials.Count();
            ViewBag.b = db.Teachers.Count();
            ViewBag.c = db.Students.Count();
            ViewBag.d = db.MailSubscribes.Count();
            ViewBag.e = db.Parents.Count();
            return View();
        }


    }
}