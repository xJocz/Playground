using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Playground.Utils
{
    class DriverFactory
    {
        private static IWebDriver driver = null;

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                driver = new ChromeDriver();
                return driver;
            }

            return driver;
        }

        public static void KillDriver()
        {
            if (driver != null)
            {
                driver.Quit();
            }

            driver = null;
        }
    }
}
