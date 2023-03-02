using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumFrameWork
{
    public class Driver
    {
       private static IWebDriver driver;

        public static void SetupDriver()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenUrl(string url) 
        {
            driver.Url = url;
            driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}
