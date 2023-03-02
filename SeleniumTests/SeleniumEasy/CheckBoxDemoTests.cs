using NUnit.Framework;
using SeleniumFrameWork;
using SeleniumFrameWork.Pages.SeleniumEasy;
using System.Collections.Generic;

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
            string actualResult = CheckBoxDemo.GetSingleCheckboxSuccessMessage();

            Assert.AreEqual(expectedMessage, actualResult);
        }

        [Test]
        public void MultipleCheckboxes()
        {
            string expectedButtonText = "Uncheck All";

            CheckBoxDemo.ClickEachOfMultipleCheckboxes();
            string actualButtonText = CheckBoxDemo.GetMultipleCheckboxButtonText();

            Assert.AreEqual(expectedButtonText, actualButtonText);
        }

        [Test]
        public void MultipleCheckboxesByButton()
        {
            CheckBoxDemo.ClickButtonCheckAll();
            Assert.IsTrue(CheckBoxDemo.GetCheckbox1Status());
            Assert.IsTrue(CheckBoxDemo.GetCheckbox2Status());
            Assert.IsTrue(CheckBoxDemo.GetCheckbox3Status());
            Assert.IsTrue(CheckBoxDemo.GetCheckbox4Status());

            CheckBoxDemo.ClickButtonCheckAll();
            Assert.IsFalse(CheckBoxDemo.GetCheckbox1Status());
            Assert.IsFalse(CheckBoxDemo.GetCheckbox2Status());
            Assert.IsFalse(CheckBoxDemo.GetCheckbox3Status());
            Assert.IsFalse(CheckBoxDemo.GetCheckbox4Status());
        }

        [Test]
        public void MultipleCheckboxesStatusCheck()
        {
            List<bool> statuses = CheckBoxDemo.GetStatusOfAllCheckboxes();

            foreach (bool status in statuses)
            {
                Assert.IsFalse(status);
            }
        }

        [Test]
        public void MultipleCheckboxesWithIntermediaryAsserts()
        {
            string buttonTextUncheck = "Uncheck All";
            string buttonTextCheck = "Check All";

            CheckBoxDemo.ClickCheckbox1();
            string actualButtonText = CheckBoxDemo.GetMultipleCheckboxButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            CheckBoxDemo.ClickCheckbox2();
            actualButtonText = CheckBoxDemo.GetMultipleCheckboxButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            CheckBoxDemo.ClickCheckbox3();
            actualButtonText = CheckBoxDemo.GetMultipleCheckboxButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            CheckBoxDemo.ClickCheckbox4();
            actualButtonText = CheckBoxDemo.GetMultipleCheckboxButtonText();
            Assert.AreEqual(buttonTextUncheck, actualButtonText);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }        
}
