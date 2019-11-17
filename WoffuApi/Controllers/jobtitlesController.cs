using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WoffuBL;

namespace WoffuApi.Controllers
{
    public class jobtitlesController : ApiController
    {
        BussinessLayer BL = new BussinessLayer();
            // GET api/values
            public IHttpActionResult Get()
            {
                return Json( BL.GetJobTitles());
            }

            // GET api/values/5
            public IHttpActionResult Get(int id)
            {
                return Json(BL.GetJobTitle(id));
            }

            // POST api/values
            public IHttpActionResult Post( [FromBody]string value)
            {
                return Json(new BussinessLayer().PostJobTitle( value));
            }

            // PUT api/values/5
            public IHttpActionResult Put(int id, [FromBody]string value)
            {
                return Json(BL.PutJobTitle(id, value));
            }

            // DELETE api/values/5
            public IHttpActionResult Delete(int id)
            {
                return Json(BL.DeleteJobTitle(id));
            }
        
    }
}
