using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KidKinder.Models.Entities;
using KidKinder.Context;
using System.Web.Security;

namespace KidKinder.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        // GET: Login
      
        
        [HttpGet]
        public ActionResult Log()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Log(Admin admin)
        {
            KidKinderContext db = new KidKinderContext();
            var result = db.Admins.FirstOrDefault(x => x.Username == admin.Username && x.Password == admin.Password);
            if (result !=null)
            {
                FormsAuthentication.SetAuthCookie(result.Username, true);
                Session["username"] = result.Username.ToString();
                return RedirectToAction("Index", "Dashboard");
            }

            return View();
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Log", "Login");
        }
    }
}