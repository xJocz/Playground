using NUnit.Framework;
using Playground.Pages;

namespace Playground.Tests
{
    class RegisterTests : Core.Base
    {
        private string URL = "http://tutorialsninja.com/demo/index.php";
        RegisterAccountPage registerPage;

        [Test]
        [TestCase("Qwer!234", "Qwer!234")]
        [TestCase("123Senh@", "123Senh@")]
        [TestCase("1234test", "1234test")]
        public void ShouldRegisterAValidNewUser(string pass, string passConfirmation)
        {
            HomePage homePage = new HomePage(URL);
            registerPage = homePage.navigateToRegisterPage();
            var result = registerPage.RegisterNewUser(pass, passConfirmation);
            Assert.AreEqual("Your Account Has Been Created!", result);
        }

        [Test]
        [TestCase("Qwer!234", "123Senh@")]
        [TestCase("123Senh@", "Qwer!234")]
        [TestCase("1234test", "test1234")]
        public void ShouldRegisterANewUserWithInvalidPassword(string pass, string passConfirmation)
        {
            HomePage homePage = new HomePage(URL);
            registerPage = homePage.navigateToRegisterPage();
            var result = registerPage.RegisterNewUserWithInvalidPassword(pass, passConfirmation);
            Assert.AreEqual("Password confirmation does not match password!", result);
        }
    }
}
