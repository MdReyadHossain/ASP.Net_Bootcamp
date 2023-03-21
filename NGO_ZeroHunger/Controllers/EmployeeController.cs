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
        public ActionResult Dashboard()
        {
            return View();
        }


        [HttpGet]
        public ActionResult AllRequest()
        {
            string name = (string)Session["employeeName"];
            NGO_Entities requestDB = new NGO_Entities();
            var request = (from req in requestDB.Requests
                           where req.employee.Equals(name) && req.status.Equals("Assigned")
                           select req);
            return View(request);
        }

        [HttpPost]
        public ActionResult AllRequest(Request req)
        {
            var requestDB = new NGO_Entities();
            var request = (from r in requestDB.Requests
                           where r.id.Equals(req.id)
                           select r).SingleOrDefault();

            requestDB.Entry(request).CurrentValues.SetValues(req);
            requestDB.SaveChanges();
            return RedirectToAction("AssignedRequest", "Employee");
        }


        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login", "Home");
        }
    }
}