using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPractice
{
    class MainPage
    {
        public IWebElement Logo => Webdrivers.Driver.FindElement(By.XPath("//a[@href='http://automationpractice.com/']"));
        public string PageName => Webdrivers.Driver.Title;
    }
}
