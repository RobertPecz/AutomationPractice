using OpenQA.Selenium;
using System;

namespace CustomWaits
{
    public class ExpectedConditions
    {
        public static Func<IWebDriver, IWebElement> ElementIsVisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    if(element.Displayed == true)
                    {
                        return element;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (StaleElementReferenceException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
                catch (Exception e)
                { 
                    Console.WriteLine(e.Message);
                    return null;
                }
            };
        }
    }
}
