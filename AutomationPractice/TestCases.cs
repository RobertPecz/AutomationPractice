using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.WaitHelpers;
using System;
using System.Text.RegularExpressions;

namespace AutomationPractice
{
    [TestFixture(typeof(ChromeDriver))]
    [TestFixture(typeof(FirefoxDriver))]
    public class TestCases<TWebdrivers> where TWebdrivers : IWebDriver, new()
    {
        [SetUp]
        public void Initialize()
        {
            Webdrivers<TWebdrivers>.Initialize();
            Webdrivers<TWebdrivers>.Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Test]
        public void STTC_001()
        {
            MainPage<TWebdrivers> mainPage = new MainPage<TWebdrivers>();
            UiInteractions<TWebdrivers>.ClickOn(mainPage.Logo);
            
            Assert.AreEqual(mainPage.PageName, Webdrivers<TWebdrivers>.Driver.Title);
        }
        [Test]
        public void STTC_002()
        {
            string searchBarLocator = "//input[@id='search_query_top']";
            MainPage<TWebdrivers> mainPage = new MainPage<TWebdrivers>();
            UiInteractions<TWebdrivers>.ClickOn(mainPage.SearchBar);
            UiInteractions<TWebdrivers>.SendText(searchBarLocator, "dress");
            UiInteractions<TWebdrivers>.ClickOn(mainPage.SearchButton);           
            mainPage.GetPageUrl(@"//h1/span[contains(text(), 'dress')]");
            Regex rgx = new Regex("[^a-zA-Z]");
            string stringToAssert = rgx.Replace(mainPage.SearchResult.Text, "");
            StringAssert.Contains(stringToAssert.ToLower(), mainPage.SearchResultUrl);

        }
        [Test]
        public void STTC_005()
        {
            MainPage<TWebdrivers> mainPage = new MainPage<TWebdrivers>();
            ContactUsPage<TWebdrivers> contactUs = mainPage.ClickOnContactUSButton();
            string contactUsText = contactUs.ContactUSH1.GetAttribute("innerText");
            Assert.AreEqual("Customer service - Contact us", contactUsText);
        }
        [Test]
        public void STTC_007()
        {
            MainPage<TWebdrivers> mainPage = new MainPage<TWebdrivers>();
            EmailCreator email = new EmailCreator();
            email.CreateTemporaryEmail();          
        }
        [Test]
        public void STTC_008()
        {
            string signInEmailXPath = "//input[@id='email']";
            string signInPasswordXPath = "//input[@id='passwd']";
            MainPage<TWebdrivers> mainPage = new MainPage<TWebdrivers>();
            RegisterAndLoginPage<TWebdrivers> registerAndLoginPage = mainPage.ClickOnSignInButton();          
            UiInteractions<TWebdrivers>.SendText(signInEmailXPath, "hulitiduv@tovinit.com");
            UiInteractions<TWebdrivers>.SendText(signInPasswordXPath, "12345");
            UiInteractions<TWebdrivers>.ClickOn(registerAndLoginPage.LoginButton);
            WebdriverWaiter<TWebdrivers>.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@class='account']/span[contains(text(), 'Random Person')]")));
        }

        [TearDown]
        public void CleanUp()
        {
            Webdrivers<TWebdrivers>.Driver.Close();
        }
    }
}
