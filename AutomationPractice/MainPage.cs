using OpenQA.Selenium;

namespace AutomationPractice
{
    class MainPage<TWebdrivers> where TWebdrivers : IWebDriver, new()
    {
        public IWebElement Logo => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//a[@href='http://automationpractice.com/']"));
        public string PageName => Webdrivers<TWebdrivers>.Driver.Title;
    }
}
