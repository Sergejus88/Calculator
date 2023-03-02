using NUnit.Framework;
using SeleniumFrameWork;
using System.Collections.Generic;

namespace SeleniumTests.SeleniumEasy
{
    internal class CheckBoxDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            CheckboxDemo.Open();
        }

        [Test]
        public void SingleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";

            CheckboxDemo.ClickSingleCheckbox();
            string actualResult = CheckboxDemo.GetSingleCheckboxSuccessMessage();

            Assert.AreEqual(expectedMessage, actualResult);
        }

        [Test]
        public void MultipleCheckboxes()
        {
            string expectedButtonText = "Uncheck All";

            CheckboxDemo.ClickEachOfMultipleCheckboxes();
            string actualButtonText = CheckboxDemo.GetMultipleCheckboxButtonText();

            Assert.AreEqual(expectedButtonText, actualButtonText);
        }

        [Test]
        public void MultipleCheckboxesByButton()
        {
            CheckboxDemo.ClickButtonCheckAll();
            Assert.IsTrue(CheckboxDemo.GetCheckbox1Status());
            Assert.IsTrue(CheckboxDemo.GetCheckbox2Status());
            Assert.IsTrue(CheckboxDemo.GetCheckbox3Status());
            Assert.IsTrue(CheckboxDemo.GetCheckbox4Status());

            CheckboxDemo.ClickButtonCheckAll();
            Assert.IsFalse(CheckboxDemo.GetCheckbox1Status());
            Assert.IsFalse(CheckboxDemo.GetCheckbox2Status());
            Assert.IsFalse(CheckboxDemo.GetCheckbox3Status());
            Assert.IsFalse(CheckboxDemo.GetCheckbox4Status());
        }

        [Test]
        public void MultipleCheckboxesStatusCheck()
        {
            List<bool> statuses = CheckboxDemo.GetStatusOfAllCheckboxes();

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

            CheckboxDemo.ClickCheckbox1();
            string actualButtonText = CheckboxDemo.GetMultipleCheckboxButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            CheckboxDemo.ClickCheckbox2();
            actualButtonText = CheckboxDemo.GetMultipleCheckboxButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            CheckboxDemo.ClickCheckbox3();
            actualButtonText = CheckboxDemo.GetMultipleCheckboxButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            CheckboxDemo.ClickCheckbox4();
            actualButtonText = CheckboxDemo.GetMultipleCheckboxButtonText();
            Assert.AreEqual(buttonTextUncheck, actualButtonText);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }        
}
