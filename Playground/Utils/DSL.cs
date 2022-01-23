using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using static Playground.Utils.DriverFactory;

namespace Playground.Utils
{
    public class DSL
    {
        public void SetText(By selector, string value)
        {
            try
            {
                GetDriver().FindElement(selector).SendKeys(value);
                Console.WriteLine($"The value '{value}' was written on '{selector}'");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred when the automation tried to type data on {selector}, Error: {ex.Message}");
                throw;
            }
        }

        public string GetText(By selector)
        {
            try
            {
                var text = GetDriver().FindElement(selector).Text;
                Console.WriteLine($"The value from selector '{selector}' was retrieved!");
                return text;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred when the automation tried to retrieve the text on selector {selector}, Error: {ex.Message}");
                throw;
            }
        }

        public void SelText(By selector, string value)
        {
            try
            {
                IWebElement element = GetDriver().FindElement(selector);
                SelectElement select = new SelectElement(element);
                select.SelectByText(value);
                Console.WriteLine($"The text '{value}' was selected on '{selector}'!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred when the automation tried to select the text '{value}' on '{selector}', Error: {ex.Message}");
                throw;
            }
        }

        public void SelValue(By selector, string value)
        {
            try
            {
                IWebElement element = GetDriver().FindElement(selector);
                SelectElement select = new SelectElement(element);
                select.SelectByValue(value);
                Console.WriteLine($"The value '{value}' was selected on '{selector}'!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred when the automation tried to select the value '{value}' on '{selector}', Error: {ex.Message}");
                throw;
            }
        }


        public void Navigate(string value)
        {
            try
            {
                GetDriver().Navigate().GoToUrl(value);
                Console.WriteLine($"The automation navigated to {value}!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Some error has occurred when the automation tried to navigate to {value}, Error: {ex.Message}");
                throw;
            }
        }

        public void Click(By selector)
        {
            try
            {
                GetDriver().FindElement(selector).Click();
                Console.WriteLine($"The item '{selector}' was clicked!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred when the automation tried to click on {selector}, Error: {ex.Message}!");
                throw;
            }
        }

        public void SwitchTab()
        {
            try
            {
                GetDriver().SwitchTo().Window(GetDriver().WindowHandles[1]);
                Console.WriteLine("The automation focus was changed for the recent opened tab");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error has occurred when the automation tried to change the focused tab, Error: {ex.Message}!");
                throw;
            }
        }
    }
}
