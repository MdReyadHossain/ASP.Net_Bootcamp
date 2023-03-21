using NGO_ZeroHunger.Auth;
using NGO_ZeroHunger.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO_ZeroHunger.Controllers
{
    [RestaurantAthentication]
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Dashboard()
        {
            ViewBag.Message = "Restaurant";

            return View();
        }

        
        [HttpGet]
        public ActionResult CreateRequest()
        {
            string res = (string)Session["restaurantName"];

            NGO_Entities db = new NGO_Entities();
            var request = (from r in db.Requests
                           where r.restaurant_name.Equals(res) && r.status.Equals("Pending")
                           select r).ToList();

            if (request.Count() < 4)
                ViewBag.stat = true;
            else
                ViewBag.stat = false;

            return View();
        }

        [HttpPost]
        public ActionResult CreateRequest(Request req)
        {
            if (ModelState.IsValid)
            {
                var db = new NGO_Entities();
                db.Requests.Add(req);
                db.SaveChanges();
                return RedirectToAction("Dashboard", "Restaurant");
            }

            return View(req);
        }

        
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Home");
        }
    }
}