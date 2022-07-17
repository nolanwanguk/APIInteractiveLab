using System;
using APIInteractiveLab.Controllers;
using NUnit.Framework;
using APIInteractiveLab.Models;

namespace APIInteractiveLab.Tests
{
    public class CoffeeControllerTests
    {
        [Test]
        public void TestGetHome()
        {
            string expectedContent = "Coffee Home";
            var controller = new CoffeeController();
            var result = controller.GetHome();
            Assert.AreEqual(expectedContent, result);
        }
        [Test]
        public void TestGetLover()
        {
            string expectedContent = "I like coffee!";
            var controller = new CoffeeController();
            var result = controller.GetLover();
            Assert.AreEqual(expectedContent, result);
        }
        [Test]
        public void TestGetCoffee()
        {
            Coffee expected = new Coffee { Id = -1, Name = "latte" };
            var controller = new CoffeeController();
            var result = controller.GetCoffee(null);
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
        [Test]
        public void TestGetCoffee_by_name()
        {
            Coffee expected = new Coffee { Id = -1, Name = "Americano" };
            var controller = new CoffeeController();
            var result = controller.GetCoffee("Americano");
            Assert.AreEqual(expected.Name, result.Name);
            Assert.AreEqual(expected.Id, result.Id);
        }
    }
}



