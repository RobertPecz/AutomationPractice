using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

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
                Environment.SetEnvironmentVariable("webdriver.gecko.driver", @"E:\Projects\AutomationPractice\packages\Selenium.WebDriver.GeckoDriver.0.29.1\driver\win64");
                Driver = new FirefoxDriver();
            }
        }       
    }
}
