using SeleniumTests.DemoQA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFrameWork.Pages.DemoQA
{
    internal class ToolTips
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
