using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        {

        }
        [SetUp]
        public void Instantiation()
        {
            Driver.Navigate().GoToUrl("https://google.com");
        }
        [Test]
        public void Foobar()
        {
            //param: [Values] Browsers browsers
            //Webdrivers.Driver = Webdrivers.Webdriver(browsers);
            //Webdrivers.Driver.Navigate().GoToUrl("https://google.com");
        }
        [TearDown]
        public void CleanUp()
        {
            Driver.Close();
        }
    }
}
