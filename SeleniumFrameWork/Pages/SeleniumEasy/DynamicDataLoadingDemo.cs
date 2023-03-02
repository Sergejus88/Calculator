using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFrameWork.Pages.SeleniumEasy
{
    public class DynamicDataLoadingDemo
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }
        public static void ClickGetNewUserButton()
        {
            string locator = "//*[@id='save']";
            Common.ClickElement(locator);
        }

        public static string GetUserInformation()
        {
            string locator = "//*[@id='loading']";
            Common.WaitForElementToNotContainText(locator, "loading...");
            return Common.GetElementText(locator);
        }
    }
}
