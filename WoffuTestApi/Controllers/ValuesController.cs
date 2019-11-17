using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using WoffuBL;

namespace WoffuTestApi.Controllers
{
    public class jobtitlesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            return Json(new WoffuBL.BussinessLayer().GetJobTitles());
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return Json(new BussinessLayer().GetJobTitle(id));
        }

        // POST api/values
        public IHttpActionResult Post(int id, [FromBody]string value)
        {
            return Json(new BussinessLayer().PostJobTitle(value));
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Json(new BussinessLayer().PutJobTitle(id, value));
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            return Json(new BussinessLayer().DeleteJobTitle(id));
        }
    }
}
