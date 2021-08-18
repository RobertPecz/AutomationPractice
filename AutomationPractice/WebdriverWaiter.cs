using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationPractice
{
    public class WebdriverWaiter<TWebdrivers> where TWebdrivers : IWebDriver, new()
    {
        public static WebDriverWait wait = new WebDriverWait(Webdrivers<TWebdrivers>.Driver, new TimeSpan(0, 0, 60));
    }
}
