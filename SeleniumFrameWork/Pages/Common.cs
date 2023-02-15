using OpenQA.Selenium;

namespace SeleniumFrameWork.Pages
{
    internal class Common
    {
        private static IWebElement GetElement(string locator)
        {
            return Driver.GetDriver().FindElement(By.XPath(locator));
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
    }
}
