using NUnit.Framework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class ToolTipsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Tooltips.Open();
        }

        [Test]
        public void HoverOnButton()
        {
            string expectedMessage = "You hovered over the Button";

            string actualMessage = Tooltips.GetTooltipMessage();
            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
