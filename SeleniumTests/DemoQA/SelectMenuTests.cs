using NUnit.Framework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class SelectMenuTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            SelectMenu.Open();
        }

        [Test]
        public void SelectTitle()
        {
            string expectedValue = "Mr.";

            SelectMenu.SelectTitle(expectedValue);
            string actuallySelectedTitle = SelectMenu.GetSelectedTitle();

            Assert.IsTrue(actuallySelectedTitle.Contains(expectedValue));
        }
    }
}
