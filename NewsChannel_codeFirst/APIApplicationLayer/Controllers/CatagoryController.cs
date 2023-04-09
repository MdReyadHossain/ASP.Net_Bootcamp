using BusinessLogicLayer.DTOs;
using BusinessLogicLayer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIApplicationLayer.Controllers
{
    public class CatagoryController : ApiController
    {
        [HttpPost]
        [Route("api/CreateCatagory")]
        public HttpResponseMessage Create(CatagoryDTO cat)
        {
            try
            {
                var response = CatagoryService.CreateCatagory(cat);
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}
