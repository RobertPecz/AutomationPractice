using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationPractice
{
    public enum Browsers
    {
        chrome,
        firefox
    }
    [TestFixture(Browsers.chrome)]
    [TestFixture(Browsers.firefox)]
    public class TestCases : Webdrivers
    {
        public TestCases(Browsers browsers)
            : base(browsers)
        { }
        [SetUp]
        public void Instantiation()
        {
            Driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }
        [Test]
        public void STTC_001()
        {
            MainPage mainPage = new MainPage();
            mainPage.Logo.Click();
            Assert.AreEqual(mainPage.PageName, Driver.Title);
        }
        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
