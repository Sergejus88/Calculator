using NUnit.Framework;
using SeleniumFrameWork.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class ToolTipsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            ToolTips.Open();
        }

        [Test]
        public void HoverOnButton()
        {
            string expectedMessage = "You hovered over the Button";

            string actualMessage = ToolTips.GetTooltipMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
