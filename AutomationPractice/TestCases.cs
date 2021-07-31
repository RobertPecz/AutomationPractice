using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace AutomationPractice
{
    public enum Browsers
    {
        chrome,
        firefox
    }
    public class TestCases : Webdrivers
    {
        [SetUp]
        public void Instantiation()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Test]
        public void STTC_001()
        {
            MainPage mainPage = new MainPage();
            UiInteractions.ClickOn(mainPage.Logo);
            
            Assert.AreEqual(mainPage.PageName, Driver.Title);
        }
        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
