using Playground.Utils;
using OpenQA.Selenium;
using Bogus;

namespace Playground.Pages
{
    class RegisterAccountPage
    {
        private DSL interactions;
        private Faker faker;
        private By inpFirstName = By.Id("input-firstname");
        private By inpLastName = By.Id("input-lastname");
        private By inpEmail = By.Id("input-email");
        private By inpPhone = By.Id("input-telephone");
        private By inpPass = By.Id("input-password");
        private By inpPassConfirmation = By.Id("input-confirm");
        private By chkTerms = By.Name("agree");
        private By btnContinue = By.XPath("//input[@type='submit']");
        private By lblMessage = By.XPath("//div[@id='common-success']/div/div/h1");
        private By lblPassword = By.XPath("//div[@class='text-danger']");
        private string expectValidMessage = "Your Account Has Been Created!";
    
        public RegisterAccountPage()
        {
            interactions = new DSL();
            faker = new Faker();
        }

        public string RegisterNewUser(string pass, string passConfirmation)
        {
            interactions.SetText(inpFirstName, faker.Name.FirstName());
            interactions.SetText(inpLastName, faker.Name.LastName());
            interactions.SetText(inpEmail, faker.Internet.Email());
            interactions.SetText(inpPhone, faker.Phone.PhoneNumber());
            interactions.SetText(inpPass, pass);
            interactions.SetText(inpPassConfirmation, passConfirmation);
            interactions.Click(chkTerms);
            interactions.Click(btnContinue);
            return interactions.GetText(lblMessage);
        }

        public string RegisterNewUserWithInvalidPassword(string pass, string passConfirmation)
        {
            interactions.SetText(inpFirstName, faker.Name.FirstName());
            interactions.SetText(inpLastName, faker.Name.LastName());
            interactions.SetText(inpEmail, faker.Internet.Email());
            interactions.SetText(inpPhone, faker.Phone.PhoneNumber());
            interactions.SetText(inpPass, pass);
            interactions.SetText(inpPassConfirmation, passConfirmation);
            interactions.Click(chkTerms);
            interactions.Click(btnContinue);
            return interactions.GetText(lblPassword);
        }
    }
}
