using OpenQA.Selenium;

namespace AutomationPractice
{
    class RegisterAndLoginPage<TWebdrivers> where TWebdrivers : IWebDriver, new()
    {
        IWebElement SignInEmail => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//input[@id='email']"));
        IWebElement SignInPassword => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//input[@id='passwd']"));
    }
}
