using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        //~/Template/KidKinder/
        // GET: Default
        KidKinderContext db = new KidKinderContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutIndex()
        {
            return View();
        }

        public ActionResult ClassesIndex()
        {
            return View();
        }

        public ActionResult TeachersIndex()
        {
            return View();
        }

        public ActionResult GalleryIndex()
        {

            var values = db.Galleries.Where(x => x.Status == 1).ToList();
            return View(values);
        }

        public ActionResult ContactIndex()
        {
            return View();
        }

        public PartialViewResult partialHead()
        {
            return PartialView();
        }
        public PartialViewResult partialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult partialFeature()
        {
            var values = db.Features.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialService()
        {
            var values = db.Services.ToList();
            return PartialView(values);
        }
        public PartialViewResult partialAboutSmall()
        {
            var values = db.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialAboutSList()
        {
            var values = db.AboutLists.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialAbout()
        {
            var values = db.Abouts.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialClassRoom()
        {
            var values = db.ClassRooms.OrderByDescending(x => x.ClassRoomId).Take(3).ToList();
            return PartialView(values);
        }
        [HttpGet]
        public PartialViewResult partialBookASeat()
        {
            List<SelectListItem> values = (from x in db.ClassRooms.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Title,
                                               Value = x.ClassRoomId.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return PartialView();
        }
        [HttpPost]
        public ActionResult CreateBookASeat(BookASeat aSeat)
        {
            db.BookASeats.Add(aSeat);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult partialTeacher()
        {
            var values = db.Teachers.ToList();
            return PartialView(values);
        }

        //~/Template/KidKinder/
        public PartialViewResult partialTestimonial()
        {
            var values = db.Testimonials.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialFooter()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult FooterSubs(MailSubscribe subs)
        {
            db.MailSubscribes.Add(subs);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public PartialViewResult partialScripts()
        {
            return PartialView();
        }

        public PartialViewResult partialContact()
        {
            var values = db.Contacts.ToList();
            return PartialView(values);
        }


    }
}