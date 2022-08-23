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
    public class UserController : ApiController
    {
        [Route("api/user")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = UserServices.Get();
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
            var data = UserServices.Getdoc();
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
            var data = UserServices.GetOnly(id);
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
            var data = UserServices.GetPatient();
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
            var data = UserServices.GetOnly(id);
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
            var data = UserServices.GetOnly(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No Notice found");
        }
        [Route("api/user/create")]
        [HttpPost]
        public HttpResponseMessage Create(RegistrationModel a)
        {
            var data = UserServices.Create(a);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Try again");
        }
        [Route("api/user/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Update(RegistrationModel registration)
        {
            var data = UserServices.Update(registration);
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
            var data = UserServices.Delete(id);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "User Deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No User Found");
        }
    }
}
