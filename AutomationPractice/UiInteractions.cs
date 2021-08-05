using System;
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
                WebdriverWaiter<TWebdrivers>.wait.Until(ExpectedConditions.ElementToBeClickable(element)).Click();
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
                WebdriverWaiter<TWebdrivers>.wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator))).SendKeys(text);
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
