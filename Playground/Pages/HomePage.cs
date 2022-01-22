using OpenQA.Selenium;
using Playground.Utils;
using Playground.Pages;

namespace Playground.Pages
{
    class HomePage
    {
        #region Class constructor and page mappings

        private DSL interactions;
        
        public HomePage()
        {
            interactions = new DSL();
            interactions.Navigate(baseUrl);
        }

        private string baseUrl = "https://phptravels.com/demo/";
        private By btnLogin = By.XPath("//a[text()='Login']");
        private By btnSignUp = By.XPath("//a[text()='Sign up']");

        #endregion

        public SignUpPage NavigateToSignUpPage()
        {
            interactions.Click(btnSignUp);
            interactions.SwitchTab();
            return new SignUpPage();
        }
    }
}
