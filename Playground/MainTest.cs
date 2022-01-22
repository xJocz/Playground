using NUnit.Framework;
using Playground.Pages;

namespace Playground
{
    public class MainTest : Core.Base
    {
        private HomePage homePage;

        [SetUp]
        public void SetUp()
        {
            homePage = new HomePage();
        }

        [Test]
        [TestCase("Gabriel", "Leme", "test@test.br", "48974561", "Toota", "Florida Avenue", "Kansas", "FL", "45611", "OM", "11978945612", "Qwerty123", "Qwerty123")]
        public void SignUp(string firstName, string lastName, string email, string phone, string companyName, string street, string city, string state, string postCode, string country, string mobile, string pass, string passConfirmation)
        {
            SignUpPage signUpPage = homePage.NavigateToSignUpPage();
            signUpPage.Fillform(firstName, lastName, email, phone, companyName, street, city, state, postCode, country, mobile, pass, passConfirmation);
        }

    }
}