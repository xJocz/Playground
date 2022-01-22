using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static Playground.Utils.DriverFactory;

namespace Playground.Utils
{
    public class DSL
    {
        public void SetText(By selector, string value)
        {
            GetDriver().FindElement(selector).SendKeys(value);
        }

        public void SelText(By selector, string value)
        {
            IWebElement element = GetDriver().FindElement(selector);
            SelectElement select = new SelectElement(element);
            select.SelectByText(value);
        }

        public void SelValue(By selector, string value)
        {
            IWebElement element = GetDriver().FindElement(selector);
            SelectElement select = new SelectElement(element);
            select.SelectByValue(value);
        }


        public void Navigate(string value)
        {
            GetDriver().Navigate().GoToUrl(value);
        }

        public void Click(By selector)
        {
            GetDriver().FindElement(selector).Click();
        }

        public void SwitchTab()
        {
            GetDriver().SwitchTo().Window(GetDriver().WindowHandles[1]);
        }
    }
}
