using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;


namespace KidKinder.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()

        {
            var values = db.Teachers.OrderByDescending(x => x.WorkTime).ToList();
            ViewBag.toplamDers = db.ClassRooms.Count();
            ViewBag.countSeat = db.BookASeats.Count();
            ViewBag.countTeach = db.Teachers.Count();
            ViewBag.countSubs = db.MailSubscribes.Count();
            ViewBag.soCheap = db.ClassRooms.Min(x => x.Price);
            ViewBag.mostSeat = db.ClassRooms.Max(x => x.TotalSeat);
            ViewBag.sumService = db.Services.Count();
            ViewBag.sendMess = db.Testimonials.Count();
 
            return View(values);
        }
    }
}