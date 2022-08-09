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
    public class NoticeController : ApiController
    {
        [Route("api/notice")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = NoticeService.Get();
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NoContent, "Empty");
        }
        [Route("api/notice/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = NoticeService.GetOnly(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No Notice found");
        }
        [Route("api/notice/create")]
        [HttpPost]
        public HttpResponseMessage Create(NoticeModel a)
        {
            var data = NoticeService.Create(a);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError, "Try again");
        }

        [Route("api/notice/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Update(NoticeModel notice)
        {
            var data = NoticeService.Update(notice);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotAcceptable, "No Notice Found");

        }

        [Route("api/notice/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            var data = NoticeService.Delete(id);
            if (data == true)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Appointment Deleted");
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "No Appointment Found");
        }

    }
}
