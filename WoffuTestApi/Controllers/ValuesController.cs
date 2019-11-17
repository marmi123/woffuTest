using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Helpers;
using System.Web.Http;
using WoffuTestDL;

namespace WoffuTestApi.Controllers
{
    public class JobTitlesController : ApiController
    {
        // GET api/values
        public IHttpActionResult Get()
        {
            return  Json(new WoffuTestDL.DataLayer().GetJobTitles());
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            return Json(new DataLayer().GetJobTitle(id));
        }

        // POST api/values
        public IHttpActionResult Post(int id, [FromBody]string value)
        {
            return Json(new DataLayer().PostJobTitle(id, value));
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Json(new DataLayer().PutJobTitles(id, value));
        }

        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
        {
            return Json(new DataLayer().DeleteJobTitle(id));
        }
    }
}
