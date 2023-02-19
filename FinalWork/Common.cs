using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FinalWork
{
    internal class Common
    {
        internal static void Wait(int milliseconds)
        {
            System.Threading.Thread.Sleep(milliseconds);
        }

        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
        }

        private static List<IWebElement> GetElements(string locator)
        {
            return (List<IWebElement>)Driver.GetDriver().FindElement(By.XPath(locator));
        }

        internal static void ClickElement(string locator)
        {
            GetElement(locator).Click();
        }

        internal static string GetElementText(string locator)
        {
            return GetElement(locator).Text;
        }

        internal static void SendKeys(string locator, string message)
        {
            GetElement(locator).SendKeys(message);
        }

        internal static string GetAttributeValue(string locator, string attributeName)
        {
            return GetElement(locator).GetAttribute(attributeName);
        }

        internal static string GetCssValue(string locator, string propertyName)
        {
            return GetElement(locator).GetCssValue(propertyName);
        }

        internal static void ClickElements(string locator)
        {
            List<IWebElement> elements = GetElements(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        private static WebDriverWait WebDriverWait(IWebDriver webDriver, TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }

        internal static void WaitForTheSearchingIsDone(string locator)
        {
            WebDriverWait wait = WebDriverWait(Driver.GetDriver(), TimeSpan.FromSeconds(5));
            wait.Until(d => d.FindElement(By.XPath(locator)));
        }

        internal static bool CheckIfElementIsWorking(string locator)
        {
            return GetElement(locator).Enabled;
        }

        internal static string SendKeys(string FillSignUp)
        {
            return Common.SendKeys(FillSignUp);
        }

        internal static string SendKeys(object FillSignUp)
        {
            return Common.SendKeys(FillSignUp);
        }
    }
}
