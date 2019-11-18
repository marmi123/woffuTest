using System;
using System.Collections.Generic;
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
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetById()
        {
            // Disponer
            jobtitlesController controller = new jobtitlesController();

            // Actuar
            var result = controller.Get(5);

            // Declarar
            Assert.AreEqual("Comercial", result);
        }

        [TestMethod]
        public void Post()
        {
            // Disponer
            jobtitlesController controller = new jobtitlesController();

            // Actuar
            var retorn = controller.Post( "Backend Developper ");

            // Declarar
        }

        [TestMethod]
        public void Put()
        {
            // Disponer
            jobtitlesController controller = new jobtitlesController();

            // Actuar
            var retorn = controller.Put(5, "value 7");
            JsonResult<List<JobTitle>> contentResult = retorn as JsonResult<List<JobTitle>>;
            // Declarar
            Assert.IsNotNull(retorn);

            Assert.AreEqual(contentResult.Content.Count, 6);
            // Declarar
        }

        [TestMethod]
        public void Delete()
        {
            // Disponer
            jobtitlesController controller = new jobtitlesController();

            // Actuar
            var retorn = controller.Delete(5);

            // Declarar
        }
    }
}


