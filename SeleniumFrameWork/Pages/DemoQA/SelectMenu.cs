using SeleniumTests.DemoQA;

namespace SeleniumFrameWork.Pages.DemoQA
{
    public class SelectMenu
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/select-menu");
        }

        public static void SelectTitle(string expectedValue)
        {
            Common.ClickElement(Locators.SelectMenu.dropdownTitle);
            Common.ClickElement(Locators.SelectMenu.dropdownTitleOptionMr);
        }

        public static string GetSelectedTitle()
        {
            return Common.GetElementText(Locators.SelectMenu.dropdownTitle);
        }
    }
}
