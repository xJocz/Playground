using OpenQA.Selenium;
using Playground.Utils;

namespace Playground.Pages
{
    class HomePage
    {
        private DSL interactions;
        private By inpSearch = By.XPath("//div[@id='search']/input");
        private By btnSearch = By.XPath("//div[@id='search']/span/button");
        private By itemGrid = By.XPath("(//div[@id='content']/div[@class='row'][3]/div/div/div[2]/div/h4)[1]");
        private By lblInvalidSearch = By.XPath("//div[@id='content']/p[2]");
        private By btnAccount = By.XPath("//i[@class='fa fa-user']/..");
        private By btnRegister = By.XPath("//a[text()='Register']/..");

        public HomePage(string URL)
        {
            interactions = new DSL();
            interactions.Navigate(URL);
        }

        public void PerformSearch(string item)
        {
            interactions.SetText(inpSearch, item);
            interactions.Click(btnSearch);
        }

        public string GetResult()
        {
            return interactions.GetText(itemGrid);
        }

        public string GetMessage()
        {
            return interactions.GetText(lblInvalidSearch);
        }

        public RegisterAccountPage navigateToRegisterPage()
        {
            interactions.Click(btnAccount);
            interactions.Click(btnRegister);
            return new RegisterAccountPage();
        }
    }
}
