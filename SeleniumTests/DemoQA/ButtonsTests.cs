using NUnit.Framework;
using SeleniumFrameWork.Pages.DemoQA;
using SeleniumTests.BaseTests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.DemoQA
{
    internal class ButtonsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Buttons.Open();
        }

        [Test]
        public void DoubleClick()
        {
            string expectedMessage = "You have done a double click";

            Buttons.DoubleClickButton();
            string actualMessage = Buttons.GetDoubleClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void RightClick()
        {
            string expectedMessage = "You have done a right click";

            Buttons.RightClickButton();
            string actualMessage = Buttons.GetRightClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void LeftClick()
        {
            string expectedMessage = "You have done a dynamic click";

            Buttons.LeftClickButton();
            string actualMessage = Buttons.GetLeftClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }
    }
}
