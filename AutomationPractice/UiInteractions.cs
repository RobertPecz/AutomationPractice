using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace AutomationPractice
{
    public class UiInteractions : Webdrivers
    {
        public static void ClickOn(IWebElement element)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 60));
                wait.Until(ExpectedConditions.ElementToBeClickable(element)).Click();
            }
            catch (ElementNotInteractableException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
