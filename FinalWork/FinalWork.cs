using OpenQA.Selenium;
using SeleniumFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalWork
{
    public class FinalWork
    {
        public static void Open()
        {
            Driver.OpenUrl("https://www.1a.lt/users/sign_up");
        }
        internal static string FillSignUp()
        {
            return Common.SendKeys(Locators.FinalWork.FillSignUp);
        }

        internal static void inputFirstName(string inputFirstName)
        {
            Common.SendKeys(Locators.FinalWork.inputFirstName, inputFirstName);
        }

        internal static void inputLastName(string ValueInputLastname)
        {
            Common.SendKeys(Locators.FinalWork.inputLastName, ValueInputLastname);
        }

        public static void inputEmailSignUP(string valueInputEmail)
        {
            Common.SendKeys(Locators.FinalWork.inputEmail, valueInputEmail);
        }

        public static void inputPassword(string valueInputPassword)
        {
            Common.SendKeys(Locators.FinalWork.inputPassword, valueInputPassword);
        }

        internal static void inputReapetPassword(string valueInputRepeatPassword)
        {
            Common.SendKeys(Locators.FinalWork.inputFirstName, valueInputRepeatPassword);
        }

        internal static void ClickSubmitButton()
        {
            Common.ClickElement(Locators.FinalWork.buttonSubmit);
        }

        public static void OpenSignIn()
        {
            Driver.OpenUrl("https://www.1a.lt/users/sign_in");
        }

        public static string InputEmail(string expectedResult)
        {
            string locator = "//*[@id=user_email]";
            return Common.GetElementText(locator);
        }

        public static string InputPassword(string inputPassword)
        {
            string locator = "//*[@id=user_password]";
            return Common.GetElementText(locator);
        }

        public static string GetSignIn()
        {
            string locator = "//*[@id=new_user]/div[4]/input";
            return Common.GetElementText(locator);
        }

        public static void OpenMainPage()
        {
            Driver.OpenUrl("https://www.1a.lt/");
        }

        public static bool WaitForTheSearchingIsDone()
        {
            string locator = "//*[@id=q]";
            Common.WaitForTheSearchingIsDone(locator);
            return Common.CheckIfElementIsWorking(locator);
        }

        public static void OpenMainSmartCardPage()
        {
            Driver.OpenUrl("https://www.1a.lt/physical_smart_card/new");
        }

        internal static void EnterNumbers(string valueInputNumbers)
        {
            throw new NotImplementedException();
        }

        public static bool CheckIfErrorIsDisplayed()
        {
            string attributeClassValue = Common.GetAttributeValue(Locators.FinalWork.inputNumbers, "class");

            if (attributeClassValue.Contains("flash-alert-block"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckIfAdndWhatWillBeDisplayed()
        {
            Common.Wait(600);
            string attributeClassValue = Common.GetCssValue(Locators.FinalWork.inputNumbers, "fa fa-exclamation-triangle fa-1");

            if (attributeClassValue == "fa fa-exclamation-triangle fa-1")
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
