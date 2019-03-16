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
    [TestFixture]
    public class TestCases
    {
        [SetUp]
        public void Instantiation()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https:\\google.com");
        }
        [Test]
        public void Foobar() { }
    }
}
