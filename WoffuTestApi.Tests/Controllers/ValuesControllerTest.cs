using Microsoft.VisualStudio.TestTools.UnitTesting;
using WoffuTestApi.Controllers;

namespace WoffuTestApi.Tests.Controllers
{
    [TestClass]
    public class ValuesControllerTest
    {
        [TestMethod]
        public void Get()
        {
            // Disponer
            JobTitlesController controller = new JobTitlesController();

            // Actuar
            var result = controller.Get();

            // Declarar
            Assert.IsNotNull(result);
            //Assert.AreEqual(2, result.Count());
            //Assert.AreEqual("value1", result.ElementAt(0));
            //Assert.AreEqual("value2", result.ElementAt(1));
        }

        [TestMethod]
        public void GetById()
        {
            // Disponer
            JobTitlesController controller = new JobTitlesController();

            // Actuar
            var result = controller.Get(5);

            // Declarar
            Assert.AreEqual("value", result);
        }

        [TestMethod]
        public void Post()
        {
            // Disponer
            JobTitlesController controller = new JobTitlesController();

            // Actuar
            var retorn = controller.Post(1,"value");

            // Declarar
        }

        [TestMethod]
        public void Put()
        {
            // Disponer
            JobTitlesController controller = new JobTitlesController();

            // Actuar
            var retorn = controller.Put(7, "value 7");

            // Declarar
        }

        [TestMethod]
        public void Delete()
        {
            // Disponer
            JobTitlesController controller = new JobTitlesController();

            // Actuar
            var retorn = controller.Delete(5);

            // Declarar
        }
    }
}
