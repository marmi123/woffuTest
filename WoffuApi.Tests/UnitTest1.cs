using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoffuApi.Controllers;
using WoffuBL;

namespace WoffuApi.Tests
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Disponer
            jobtitlesController controller = new jobtitlesController();

            // Actuar
            System.Web.Http.IHttpActionResult result = controller.Get();
            JsonResult<List<JobTitle>> contentResult = result as JsonResult<List<JobTitle>>;
            // Declarar
            Assert.IsNotNull(contentResult.Content);
        }

        [TestMethod]
        public void GetById()
        {
            jobtitlesController controller = new jobtitlesController();

            var result = controller.Get(5);
            JsonResult<JobTitle> contentResult = result as JsonResult<JobTitle>;

            Assert.AreEqual("Comercial", contentResult.Content.Name);
        }

        [TestMethod]
        public void Post()
        {
            jobtitlesController controller = new jobtitlesController();

            var retorn = controller.Post("Backend Developper");
            JsonResult<int> contentRetorn = retorn as JsonResult<int>;
            var result = controller.Get(contentRetorn.Content);
            JsonResult<JobTitle> contentResult = result as JsonResult<JobTitle>;
            Assert.AreEqual("Backend Developper", contentResult.Content.Name);
            
        }

        [TestMethod]
        public void Put()
        {
            // Disponer
            jobtitlesController controller = new jobtitlesController();

            // Actuar
            var retorn = controller.Put(5, "value 7");
            var result = controller.Get(5);
            JsonResult<JobTitle> contentResult = result as JsonResult<JobTitle>;
            Assert.AreEqual("value 7", contentResult.Content.Name);
            retorn = controller.Put(5, "value 9");
            result = controller.Get(5);
            contentResult = result as JsonResult<JobTitle>;
            Assert.AreEqual("value 9", contentResult.Content.Name);
        }

        [TestMethod]
        public void Delete()
        {
            jobtitlesController controller = new jobtitlesController();
            System.Web.Http.IHttpActionResult listJobTitles = controller.Get();
            JsonResult<List<JobTitle>> contentList = listJobTitles as JsonResult<List<JobTitle>>;
            var firstElement = contentList.Content.OrderBy(x => x.JobTitleId).FirstOrDefault();
            //If firsOrDefault is null there is not elements in the BBDD The test fail.
            Assert.IsNotNull(firstElement);
            var id = firstElement.JobTitleId;
            var result = controller.Get(id);
            JsonResult<JobTitle> contentResult = result as JsonResult<JobTitle>;
            Assert.IsNotNull(contentResult.Content);
            var retorn = controller.Delete(id);
            result = controller.Get(id);
            contentResult = result as JsonResult<JobTitle>;
            Assert.IsNull(contentResult.Content);
        }
    }
}


