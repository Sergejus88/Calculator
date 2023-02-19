using OpenQA.Selenium;
using SeleniumTests.DemoQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFrameWork.Pages.DemoQA
{
    public class TextBoxDemo
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/text-box");
        }

        public static void EnterFullName(string valueInputName)
        {
            Common.SendKeys(Locators.TextBox.inputFullName, valueInputName);
        }

        public static void EnterEmail(string valueInputEmail)
        {
            Common.SendKeys(Locators.TextBox.inputEmail, valueInputEmail);
        }

        public static void EnterCurrentAddress(string valueInputCurrentAddress)
        {
            Common.SendKeys(Locators.TextBox.inputCurrentAddress, valueInputCurrentAddress);
        }

        public static void EnterPermanentAddress(string valueInputPermanentAddress)
        {
            Common.SendKeys(Locators.TextBox.inputPermanentAddress, valueInputPermanentAddress);
        }

        public static void ClickSubmitButton()
        {
            Common.ClickElement(Locators.TextBox.buttonSubmit);
        }

        public static string GetFullNameOutput()
        {
            return Common.GetElementText(Locators.TextBox.outputFullName);
        }

        public static string GetEmailOutput()
        {
            return Common.GetElementText(Locators.TextBox.outputEmail);
        }

        public static string GetCurrentAddressOutput()
        {
            return Common.GetElementText(Locators.TextBox.outputCurrentAddress);
        }

        public static string GetPermanentAddressOutput()
        {
            return Common.GetElementText(Locators.TextBox.outputPermanentAddress);  
        }

        //

        public static bool CheckIfEmailErrorIsDisplayed()
        {
            string attributeClassValue = Common.GetAttributeValue(Locators.TextBox.inputEmail, "class");

            if (attributeClassValue.Contains("field-error"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckIfEmailBorderIsRed()
        {
            Common.Wait(500);
            string cssBorderColor = Common.GetCssValue(Locators.TextBox.inputEmail, "border-color");

            if (cssBorderColor == "rgb(255, 0, 0)")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}    
