using Playground.Utils;
using OpenQA.Selenium;

namespace Playground.Pages
{
    class SignUpPage
    {
        #region Class constructor and page mappings

        private DSL interactions;
        public SignUpPage()
        {
            interactions = new DSL();
        }

        private By inpFirstName = By.Id("inputFirstName");
        private By inpLastName = By.Id("inputLastName");
        private By inpEmail = By.Id("inputEmail");
        private By countrySelector = By.XPath("//div[@class='selected-dial-code']");
        private By inpPhone = By.Id("inputPhone");

        private By inpCompanyName = By.Id("inputCompanyName");
        private By inpStreet = By.Id("inputAddress1");
        private By inpCity = By.Id("inputCity");
        private By inpState = By.Id("stateinput");
        private By inpPostCode = By.Id("inputPostcode");
        private By selCountry = By.Id("inputCountry");

        private By inpMobilePhone = By.Id("customfield2");
        private By inpPass = By.Id("inputNewPassword1");
        private By inpPassConfirmation = By.Id("inputNewPassword2");

        private By receiveMessages = By.XPath("//span[@class='switch__container']");
        private By btnRegister = By.XPath("//input[@value='Register']");

        #endregion

        public void Fillform(string firstName, string lastName, string email, string phone, string companyName, string street, string city, string state, string postCode, string country, string mobile, string pass, string passConfirmation)
        {
            interactions.SetText(inpFirstName, firstName);
            interactions.SetText(inpLastName, lastName);
            interactions.SetText(inpEmail, email);

            interactions.SetText(inpPhone, phone);
            interactions.SetText(inpCompanyName, companyName);
            interactions.SetText(inpStreet, street);
            interactions.SetText(inpCity, city);
            interactions.SetText(inpState, state);
            interactions.SetText(inpPostCode, postCode);
            interactions.SelValue(selCountry, country);
            interactions.SetText(inpMobilePhone, mobile);
            interactions.SetText(inpPass, pass);
            interactions.SetText(inpPassConfirmation, passConfirmation);
        }

    }
}
