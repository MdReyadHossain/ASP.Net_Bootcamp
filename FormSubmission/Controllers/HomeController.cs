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
            if (ModelState.IsValid)
            {
                bool isValid = false;
                var db = new EcommerceEntities();
                var customers = db.Customers;
                foreach (var i in customers)
                {
                    if (i.Name == login.Username && i.Password == login.Password)
                    {
                        isValid = true;
                        return RedirectToAction("Dashboard", "Customer");
                    }
                }
                if (!isValid)
                {
                    TempData["ErrMsg"] = "Username or Password invalid!";
                    return View();
                }
            }

            return View(login);
        }


        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Registration(Customer registration)
        {
            if (ModelState.IsValid)
            {
                var db = new EcommerceEntities();
                db.Customers.Add(registration);
                db.SaveChanges();
                return RedirectToAction("UserList", "Home");
            }

            return View(registration);
        }


        public ActionResult UserList()
        {
            var db = new EcommerceEntities();
            var customers = db.Customers;
            return View(customers);
        }


        [HttpGet]
        public ActionResult UserEdit(int id)
        {
            var db = new EcommerceEntities();
            var customerProfile = (from customer in db.Customers
                                   where customer.ID == id
                                   select customer).SingleOrDefault();

            return View(customerProfile);
        }


        [HttpPost]
        public ActionResult UserEdit(Customer edit)
        {
            var db = new EcommerceEntities();
            var customers = (from customer in db.Customers
                             where customer.ID == edit.ID
                             select customer).SingleOrDefault();

            db.Entry(customers).CurrentValues.SetValues(edit);
            db.SaveChanges();
            return RedirectToAction("UserList", "Home");
        }


        [HttpGet]
        public ActionResult UserDelete(int id)
        {
            var db = new EcommerceEntities();
            var customers = (from customer in db.Customers
                             where customer.ID == id
                             select customer).SingleOrDefault();

            db.Customers.Remove(customers);
            db.SaveChanges();
            return RedirectToAction("UserList", "Home");
        }
    }
}