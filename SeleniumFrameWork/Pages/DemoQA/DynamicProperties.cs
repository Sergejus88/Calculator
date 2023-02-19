using System;

namespace SeleniumFrameWork.Pages.DemoQA
{
    public class DynamicProperties
    {
        public static bool WaitForButtonToBeClickable() 
        {
            string locator = "//*[@id=enableAfter]";
            Common.WaitForElementToBeClickable(locator);
            return Common.CheckIfElementIsEnabled(locator);
        }
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/dynamic-properties");
        }

    }
}
