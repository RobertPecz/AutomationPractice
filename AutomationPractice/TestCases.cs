using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

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
        [TearDown]
        public void CleanUp()
        {
            Webdrivers<TWebdrivers>.Driver.Close();
        }
    }
}
