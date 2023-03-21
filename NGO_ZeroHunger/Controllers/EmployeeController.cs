using NGO_ZeroHunger.Auth;
using NGO_ZeroHunger.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO_ZeroHunger.Controllers
{
    [EmployeeAuthentication]
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult Dashboard()
        {
            string name = (string)Session["employeeName"];
            NGO_Entities requestDB = new NGO_Entities();
            var request = (from req in requestDB.Requests
                           where req.employee.Equals(name) && req.status.Equals("Assigned")
                           select req);

            ViewBag.reqCount =  request.Count();
            return View(request);
        }

        [HttpPost]
        public ActionResult Dashboard(Request req)
        {
            var requestDB = new NGO_Entities();
            var request = (from r in requestDB.Requests
                           where r.id.Equals(req.id)
                           select r).SingleOrDefault();

            request.done_time = req.done_time;
            request.status = req.status;

            requestDB.SaveChanges();
            return RedirectToAction("Dashboard", "Employee");
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Home");
        }
    }
}