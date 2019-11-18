using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WoffuApi.Filters;
using WoffuBL;

namespace WoffuApi.Controllers
{
    [BasicAuthentication]
    
    public class jobtitlesController : ApiController
    {
        BussinessLayer BL = new BussinessLayer(Path.Combine(AppDomain.CurrentDomain.BaseDirectory));
            //System.Web.HttpContext.Current.Server.MapPath("~"));
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
        public IHttpActionResult Post([FromBody]string name)
            {           
                return Json(BL.PostJobTitle( name));
            }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody]string name)
            {
                return Json(BL.PutJobTitle(id, name));
            }
        // DELETE api/values/5
        public IHttpActionResult Delete(int id)
            {
                return Json(BL.DeleteJobTitle(id));
            }
        
    }
}
