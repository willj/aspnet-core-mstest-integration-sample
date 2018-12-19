using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSUnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private readonly WebApplicationFactory<TestTestApp.Startup> _factory;

        public UnitTest1()
        {
            _factory = new WebApplicationFactory<TestTestApp.Startup>();
        }

        [TestMethod]
        public async Task TestMethod1()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/");

            response.EnsureSuccessStatusCode();

            Assert.AreEqual("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
