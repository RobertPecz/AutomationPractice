using OpenQA.Selenium;

namespace AutomationPractice
{
    class RegisterAndLoginPage<TWebdrivers> where TWebdrivers : IWebDriver, new()
    {
        public IWebElement SignInEmail => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//input[@id='email']"));
        public IWebElement SignInPassword => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//input[@id='passwd']"));
        public IWebElement LoginButton => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//button[@id='SubmitLogin']"));
    }
}
