using NUnit.Framework;
using SeleniumFrameWork;
using SeleniumFrameWork.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class CheckBoxDemoTests
    {
        [SetUp]
        public void SetUp() 
        { 
            Driver.SetupDriver();
            CheckBoxDemo.Open();
        }

        [Test]
        public void SingleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";

            CheckBoxDemo.ClickSingleCheckbox();
            string actualResult = CheckBoxDemo.GetSingleCheckboxDemoSuccessMessage();

            Assert.AreEqual(expectedMessage, actualResult);
        }

        [Test]
        public void MultipleCheckboxes()
        {
            string expectedButtonText = "Uncheck All";

            CheckBoxDemo.ClickEachofMultipleTextboxes();
            string actualButtonText = CheckBoxDemo.GetMultipleCheckboxButtonText();

            Assert.AreEqual(expectedButtonText, actualButtonText);
        }

        [TearDown] 
        public void TearDown() 
        {
            Driver.CloseDriver();
        }
    }
}
