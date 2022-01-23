using NUnit.Framework;
using Playground.Pages;

namespace Playground.Tests
{
    class RegisterTests : Core.Base
    {
        private string URL = "http://tutorialsninja.com/demo/index.php";
        RegisterAccountPage registerPage;

        [Test]
        [TestCase("Denis", "Almeida", "test@test.br", "11974391234", "Qwer!234", "Qwer!234")]
        [TestCase("Carlos", "Tito", "testing@test.qa", "11999101888", "123Senh@", "123Senh@")]
        [TestCase("Milena", "Naiara", "testingagain@test.ce", "11974881241", "1234test", "1234test")]
        public void ShouldRegisterAValidNewUser(string firstName, string lastName, string email, string phone, string pass, string passConfirmation)
        {
            HomePage homePage = new HomePage(URL);
            registerPage = homePage.navigateToRegisterPage();
            var result = registerPage.RegisterNewUser(firstName, lastName, email, phone, pass, passConfirmation);
            Assert.AreEqual("Your Account Has Been Created!", result);
        }
    }
}
