using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FormSubmission.Entity;
using FormSubmission.Models;


namespace FormSubmission.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel login)
        {
            return View(login);
        }


        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registration(DotNetUser registration)
        {
            if (ModelState.IsValid)
            {
                var db = new ASPDBEntities();
                db.DotNetUsers.Add(registration);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(registration);
        }
    }
}