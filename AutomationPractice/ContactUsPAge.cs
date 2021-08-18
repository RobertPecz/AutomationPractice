using OpenQA.Selenium;

namespace AutomationPractice
{
    class ContactUsPage<TWebdrivers> where TWebdrivers : IWebDriver, new()
    {
        public IWebElement ContactUSH1 => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//h1[@class='page-heading bottom-indent']"));
    }
}
