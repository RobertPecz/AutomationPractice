using System;
using CustomWaits;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace AutomationPractice
{
    public class UiInteractions<TWebdrivers> where TWebdrivers : IWebDriver, new()
    {
        public static void ClickOn(IWebElement element)
        {
            try
            {               
                WebdriverWaiter<TWebdrivers>.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element)).Click();    
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
        public static void SendText(string locator, string text)
        {
            try
            {
                WebdriverWaiter<TWebdrivers>.wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(locator))).SendKeys(text);
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
        public static void SendText(IWebElement element, string text)
        {
            try
            {
                WebdriverWaiter<TWebdrivers>.wait.Until(CustomWaits.ExpectedConditions.ElementIsVisible(element)).SendKeys(text);
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
