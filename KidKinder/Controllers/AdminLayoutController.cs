using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Context;

namespace KidKinder.Controllers
{
    public class AdminLayoutController : Controller
    {
        // GET: AdminLayout
        KidKinderContext db = new KidKinderContext();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult partialHead()
        {
            return PartialView();
        }

        public PartialViewResult partialPreLoader()
        {
            return PartialView();
        }

        public PartialViewResult partialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult partialNotification()
        {
            var values = db.Notifications.ToList();
            return PartialView(values);
        }

        public PartialViewResult partialNavbarProfileHeader()
        {
            return PartialView();
        }

        public PartialViewResult partialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult partialScripts()
        {
            return PartialView();
        }

        public PartialViewResult partialHeader()
        {
            return PartialView();
           
        }
    }
}