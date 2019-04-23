using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace AutomationPractice
{
    public class Webdrivers
    {
        public static IWebDriver Driver { get; set; }
        public Webdrivers(Browsers browsers)
        {
            Driver = Webdriver(browsers);
        }      
        public static IWebDriver Webdriver(Browsers browsers)
        {           
                switch(browsers)
                {
                    case Browsers.chrome:
                        return new ChromeDriver();
                        
                    case Browsers.firefox:
                        return new FirefoxDriver();
                        
                }
                return Driver;
        }       
    }
}
