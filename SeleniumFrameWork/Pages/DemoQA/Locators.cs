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
            internal static string buttonSubmit = "//*[@id='submit']/..";
            internal static string outputFullName = "//*[@id='output']//*[@id='name']";
            internal static string outputEmail = "//*[@id='output']//*[@id='email']";
            internal static string outputCurrentAddress = "//*[@id='output']//*[@id='currentAddress']";
            internal static string outputPermanentAddress = "//*[@id='output']//*[@id='permanentAddress']";
        }

        internal class Buttons
        {
            internal static string buttonDoubleClick = "//*[@id='doubleClickBtn']";
            internal static string buttonRightClick = "//*[@id='rightClickBtn']";
            internal static string buttonLeftClick = "//*[text()='Click Me']";
            internal static string messageDoubleClick = "//*[@id='doubleClickMessage']";
            internal static string messageRightClick = "//*[@id='rightClickMessage']";
            internal static string messageLeftClick = "//*[@id='dynamicClickMessage']";
        }

        internal class Tooltips
        {
            internal static string elementTooltip = "//*[@class='tooltip-inner']";
            internal static string buttonHoverMeToSee = "//*[@id='toolTipButton']";
        }

        internal class SelectMenu
        {
            internal static string dropdownTitle = "//*[@id='selectOne']";
            internal static string dropdownTitleOptionMr = "//*[@id='selectOne']//div[text()='Mr.']";
        }
    }
}

