using NUnit.Framework;
using Playground.Pages;

namespace Playground
{
    public class HomeTests : Core.Base
    {
        private string URL = "http://tutorialsninja.com/demo/index.php";

        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        [TestCase("MacBook")]
        [TestCase("iPhone")]
        [TestCase("Canon EOS 5D")]
        public void ShouldPerformValidSearch(string item)
        {
            HomePage homePage = new HomePage(URL);
            homePage.PerformSearch(item);
            var gridResult = homePage.GetResult();
            Assert.AreEqual(item.ToLower(), gridResult.ToLower());
        }

        [Test]
        [TestCase("Vodka")]
        [TestCase("Gin")]
        [TestCase("Beer")]
        public void ShouldPerformInvalidSearch(string item)
        {
            HomePage homePage = new HomePage(URL);
            homePage.PerformSearch(item);
            var message = homePage.GetMessage();
            Assert.AreEqual("There is no product that matches the search criteria.", message);
        }

    }
}