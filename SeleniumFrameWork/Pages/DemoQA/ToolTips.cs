using SeleniumTests.DemoQA;

namespace SeleniumFrameWork.Pages.DemoQA
{
    public class ToolTips
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/tool-tips");
        }

        public static string GetTooltipMessage()
        {
            Common.MoveMouseToElement(Locators.Tooltips.buttonHoverMeToSee);
            Common.WaitForElementToBeVisible(Locators.Tooltips.elementTooltip);
            return Common.GetElementText(Locators.Tooltips.elementTooltip);
        }
    }
}
