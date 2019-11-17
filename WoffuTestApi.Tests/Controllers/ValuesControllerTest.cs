using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Web.Http.Results;
using WoffuTestApi.Controllers;
using WoffuBL;

namespace WoffuTestApi.Tests.Controllers
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

            Assert.AreEqual(contentResult.Content.Count, 6);
            //Assert.AreEqual("value2", result.ElementAt(1));
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
            var retorn = controller.Post(1, "value");

            // Declarar
        }

        [TestMethod]
        public void Put()
        {
            // Disponer
            jobtitlesController controller = new jobtitlesController();

            // Actuar
            var retorn = controller.Put(7, "value 7");

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
