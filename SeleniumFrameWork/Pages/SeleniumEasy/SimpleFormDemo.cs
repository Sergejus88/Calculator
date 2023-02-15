using System;

namespace SeleniumFrameWork.Pages.SeleniumEasy
{

    public class SimpleFormDemo
    {
        public static void EnterMessage(string message)
        {
            string locator = "//*[@id='user-message']";
            Common.SendKeys(locator, message);
        }

        public static void ClickShowMessageButton()
        {
            string locator = "//*[@id='get-input']/button";
            Common.ClickElement(locator);
        }

        public static string GetSingleInputFieldMessage()
        {
            string locator = "//*[@id='display']";
            return Common.GetElementText(locator);
        }




        public static void EnterInputA(string value)
        {
            string locator = "//*[@id='sum1']";
            Common.SendKeys(locator, value);
        }

        public static void EnterInputB(string value)
        {
            string locator = "//*[@id='sum2']";
            Common.SendKeys(locator, value);
        }

        public static void ClickGetTotalButton()
        {
            string locator = "//*[@id='gettotal']/button";
            Common.ClickElement(locator);
        }


        public static string GetTwoInputFieldsMessage()
        {
            string locator = "//*[@id='displayvalue']";
            return Common.GetElementText(locator);
        }



        
        public static void inputFullName(string value)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeys(locator, value);
        }
           
        public static void InputE(string value)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, value);
        }

        public static void inputCurrent(string value)
        {
            string locator = "//*[@id='currentAddress']";
            Common.SendKeys(locator, value);
        }

        public static void inputPermanent(string value)
        {
            string locator = "//*[@id='permanentAddress']";
            Common.SendKeys(locator, value);
        }

        public static string GetTextBox()
        {
            string locator = "//*[@id='submit']";
            return Common.GetElementText(locator);
        }



        public static void InputEInvalidEmail(string value)
        {
            string locator = "//*[@id='userEmail']";
            Common.SendKeys(locator, value);
        }
    
        public static string GetFillBadFormaWithInvalidEmail()
        {
            string locator = "//*[@id='submit']";
            return Common.GetElementText(locator);

        }
    }
}
      

