using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MSUnitTestProject1
{
    [TestClass]
    public class CustomFactoryTests
    {
        private readonly CustomWebApplicationFactory<TestTestApp.Startup> _factory;

        public CustomFactoryTests()
        {
            _factory = new CustomWebApplicationFactory<TestTestApp.Startup>();
        }

        [TestMethod]
        public async Task TestMethod2()
        {
            var client = _factory.CreateClient();

            var response = await client.GetAsync("/");

            response.EnsureSuccessStatusCode();

            Assert.AreEqual("text/html; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }
    }
}
