using BusinessLogicLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIAppLayer.Controllers
{
    public class EmpController : ApiController
    {
        [HttpGet]
        [Route("api/Employees")]
        public HttpResponseMessage AllEmployee()
        {
            try
            {
                var data = EmpService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
