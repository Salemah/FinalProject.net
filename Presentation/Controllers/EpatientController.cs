using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class EpatientController : ApiController
    {
        [Route("api/epatient")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = EpatientService.Get();
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NoContent, "Empty");
        }
        [Route("api/epatient/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = EpatientService.GetOnly(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No Emergency patient  found");
        }
        [Route("api/epatient/create")]
        [HttpPost]
        public HttpResponseMessage Create(EpatientModel a)
        {
            var data = EpatientService.Create(a);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Try again");
        }

        [Route("api/epatient/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Update(EpatientModel notice)
        {
            var data = EpatientService.Update(notice);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotAcceptable, "No Emergency patient  Found");

        }

        [Route("api/epatient/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = EpatientService.Delete(id);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Emergency patient Deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No Notice Found");
        }



    }
}
