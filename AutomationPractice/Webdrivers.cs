using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationPractice
{
    public class Webdrivers<TWebDrivers> where TWebDrivers : IWebDriver, new()
    {
        public static IWebDriver Driver { get; set; }

        public static void Initialize()
        {
            if (typeof(TWebDrivers) == typeof(ChromeDriver))
            {
                Driver = new ChromeDriver();
            }
            else
            {
                Driver = new FirefoxDriver();
            }
        }       
    }
}
