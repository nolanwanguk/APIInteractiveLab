using System;
using APIInteractiveLab.Controllers;
using NUnit.Framework;

namespace APIInteractiveLab.Tests
{
    public class HomeControllerTests
    {
        [Test]
        public void TestGetHome()
        {
            string expectedContent = "Welcome to the Drinks API!";
            var controller = new HomeController();
            var result = controller.GetHome();
            Assert.AreEqual(expectedContent, result);
        }
    }
}
