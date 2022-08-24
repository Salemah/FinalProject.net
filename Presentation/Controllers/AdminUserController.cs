using BLL.BOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Presentation.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AdminUserController : ApiController
    {
        [Route("api/user")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdminUserServices.Get();
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NoContent, "Empty");
        }
        /* admin doctor get */


        [Route("api/user/doctor")]
        [HttpGet]
        public HttpResponseMessage Getdoc()
        {
            var data = AdminUserServices.Getdoc();
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NoContent, "Empty");
        }
        [Route("api/user/doctor/{id}")]
        [HttpGet]
        public HttpResponseMessage Getdoc(int id)
        {
            var data = AdminUserServices.GetOnly(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No Notice found");
        }


        /*admin patient get */
        [Route("api/user/patient")]
        [HttpGet]
        public HttpResponseMessage GetPatient()
        {
            var data = AdminUserServices.GetPatient();
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NoContent, "Empty");
        }
        [Route("api/user/patient/{id}")]
        [HttpGet]
        public HttpResponseMessage GetPatient(int id)
        {
            var data = AdminUserServices.GetOnly(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No Notice found");
        }


        /*admin patient get */

        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = AdminUserServices.GetOnly(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No Notice found");
        }
        [Route("api/user/create")]
        [HttpPost]
        public HttpResponseMessage Create(AdminRegistrationModel a)
        {
            var data = AdminUserServices.Create(a);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Try again");
        }
        [Route("api/user/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Update(AdminRegistrationModel registration)
        {
            var data = AdminUserServices.Update(registration);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotAcceptable, "No User Found");

        }

        [Route("api/user/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = AdminUserServices.Delete(id);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "User Deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No User Found");
        }

        [Route("api/user/count")]
        [HttpGet]
        public HttpResponseMessage Dcccount()
        {
            var data = AdminUserServices.Dcccount();
            if (data != 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No User Found");
        }
        [Route("api/user/patient/count")]
        [HttpGet]
        public HttpResponseMessage Patientcount()
        {
            var data = AdminUserServices.Patientcount();
            if (data != 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No User Found");
        }

    }
}
