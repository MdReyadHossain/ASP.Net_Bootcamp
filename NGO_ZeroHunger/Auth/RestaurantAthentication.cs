using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NGO_ZeroHunger.Auth
{
    public class RestaurantAthentication : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            if (httpContext.Session["restaurant"] != null) return true;
            return false;
        }
    }
}