using NUnit.Framework;
using SeleniumFrameWork.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class DynamicPropertiesTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            DynamicProperties.Open();
        }

        [Test]
        public void WaitForButtonToBeClickable()
        {
            Assert.IsTrue(DynamicProperties.WaitForButtonToBeClickable());
        }

        [Test]
        public void WaitForButtonClassToChange()
        {
            DynamicProperties.WaitForButtonClassToChange();
        }

        [Test]
        public void WaitForButtonBorderToBeRed()
        {
            DynamicProperties.WaitForButtonTextToBeRed();
        }

        [Test]
        public void WaitForButtonToBeVisible()
        {
            DynamicProperties.WaitForButtonToBeVisible();
        }
    }
}    