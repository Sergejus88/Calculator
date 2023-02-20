using EntityFramework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SeleniumFrameWork.Pages.SeleniumEasy
{
    public class CheckBoxDemo2
    {
        
        public class Locators
        {
            string ActualButton1 = "//*[@id='easycont']";
            string ActualButton2 = "//*[@id='easycont']";
            string ActualButton3 = "//*[@id='easycont']";
            string ActualButton4 = "//*[@id='easycont']";
            string CheckElementMarking = "//*[@id=check1] ";
            string CheckElementIfIsCheckedValue = "//*[@id=isChkd]";        
        }
 
        public static void Open()
        {
            Driver.OpenUrl("https://demo.seleniumeasy.com/basic-checkbox-demo.html");
        }

        public static bool GetMultipleCheckboxButtonText()
        {
            return Common.GetAttributeValue(true);
        }


        internal static void ClickElements(string locator, string actualButton1, string actualButton2, string actualButton3, string actualButton4)
        {
            List<IWebElement> elements = GetElement(locator);

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static void ClickElements1(string locator, string actualButton1, string actualButton2, string actualButton3, string actualButton4)
        {
            List<IWebElement> elements = GetElement(locator); ;

            foreach(IWebElement element in elements)
            {
                element.Click();
            }
        }

        private static List<IWebElement> GetElement(string locator)
        {
            throw new NotImplementedException();
        }

        internal static void ClickElements2(string locator, string actualButton1, string actualButton2, string actualButton3, string actualButton4)
        {
            List<IWebElement> elements = GetElement(locator); ;

            foreach (IWebElement element in elements)
            {
                element.Click();
            }
        }

        internal static void ClickElements3(string locator, string actualButton1, string actualButton2, string actualButton3, string actualButton4)
        {
            List<IWebElement> elements = GetElement(locator); ;

            foreach (IWebElement element in elements)
            {
                element.Click();
            }

        }
     }
}  
