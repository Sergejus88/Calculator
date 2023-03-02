using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFrameWork.Pages.SeleniumEasy
{
    public class SelectDropDownList
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-select-dropdown-demo.html");
        }

        public static void SelectDay(string expectedDay)
        {
            string selectElementLocator = "//*[@id='select-demo']";
            Common.SelectOptionByValue(selectElementLocator, expectedDay);
        }

        public static string GetSelectedDay()
        {
            string locator = "//*[@class='selected-value']";
            return Common.GetElementText(locator);
        }
    }
}
