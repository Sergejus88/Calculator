using OpenQA.Selenium;
using SeleniumFrameWork;

namespace SeleniumTests.DemoQA
{
    internal class Locators
    {
        internal class TextBox
        {
            internal static string inputFullName = "//*[@id='userName']";
            internal static string inputEmail = "//*[@id='userEmail']";
            internal static string inputCurrentAddress = "//*[@id='currentAddress']";
            internal static string inputPermanentAddress = "//*[@id='permanentAddress']";
            internal static string buttonSubmit = "//*[@id='submit']";
            internal static string outputFullName = "//*[@id='userName']";
            internal static string outputEmail = "//*[@id='userEmail']";
            internal static string outputCurrentAddress = "//*[@id='currentAddress']";
            internal static string outputPermanentAddress = "//*[@id='permanentAddress']";
        }
    }
}

