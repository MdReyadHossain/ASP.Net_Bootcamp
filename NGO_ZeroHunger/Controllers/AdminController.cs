using NGO_ZeroHunger.Auth;
using NGO_ZeroHunger.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO_ZeroHunger.Controllers
{
    [AdminAuthentication]
    public class AdminController : Controller
    {
        public ActionResult Dashboard()
        {
            NGO_Entities requestDB = new NGO_Entities();
            var request = requestDB.Requests;
            return View(request);
        }


        
        public ActionResult PendingRequest()
        {
            NGO_Entities requestDB = new NGO_Entities();
            var request = (from req in requestDB.Requests
                           where req.status.Equals("Pending")
                           select req);
            return View(request);
        }


        [HttpGet]
        public ActionResult AssignEmployee(int id)
        {
            ViewBag.id = id;
            var db = new NGO_Entities();
            var emp = db.Employees.ToList();
            return View(emp);
        }

        [HttpPost]
        public ActionResult AssignEmployee(Request req)
        {
            var requestDB = new NGO_Entities();
            var request = (from r in requestDB.Requests
                           where r.id.Equals(req.id)
                           select r).SingleOrDefault();

            var empAvailable = (from e in requestDB.Requests
                                where e.employee.Equals(req.employee) && e.status.Equals("Assigned")
                                select e).ToList();
            if (request != null && empAvailable.Count() < 5)
            {
                request.employee = req.employee;
                request.accept_time = req.accept_time;
                request.status = req.status;

                // requestDB.Entry(request).CurrentValues.SetValues(req);
                requestDB.SaveChanges();
                return RedirectToAction("PendingRequest", "Admin");
            }

            TempData["Msg"] = req.employee + " has been assigned to max limit. Choose other employee ";
            return RedirectToAction("AssignEmployee", "Admin");
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Home");
        }
    }
}