using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomationPractice
{
    class MainPage<TWebdrivers> where TWebdrivers : IWebDriver, new()
    {
        public IWebElement Logo => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//a[@href='http://automationpractice.com/']"));
        public IWebElement SearchBar => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//input[@id='search_query_top']"));
        public IWebElement ContactUSButton => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//a[@title='Contact Us']"));
        public IWebElement SignInButton => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//a[@title='Log in to your customer account']"));
        public IWebElement SearchButton => Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath("//button[@name='submit_search']"));
        public IWebElement SearchResult; 
        public string SearchResultUrl;
        public string PageName => Webdrivers<TWebdrivers>.Driver.Title;

        public void GetPageUrl(string locator)
        {
            WebdriverWaiter<TWebdrivers>.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
            SearchResult = Webdrivers<TWebdrivers>.Driver.FindElement(By.XPath(locator));
            SearchResultUrl = Webdrivers<TWebdrivers>.Driver.Url;
        }
        public ContactUsPage<TWebdrivers> ClickOnContactUSButton()
        {
            UiInteractions<TWebdrivers>.ClickOn(ContactUSButton);
            return new ContactUsPage<TWebdrivers>();
        }
        public RegisterAndLoginPage<TWebdrivers> ClickOnSignInButton()
        {
            UiInteractions<TWebdrivers>.ClickOn(SignInButton);
            return new RegisterAndLoginPage<TWebdrivers>();
        }
    }
}
