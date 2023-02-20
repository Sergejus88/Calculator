using NUnit.Framework;
using SeleniumFrameWork.Pages.SeleniumEasy;
using SeleniumFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTests.SeleniumEasy
{
    internal class CheckBoxTests2
    {

        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            CheckBoxDemo.Open();
        }

        [Test]
        public void MultipleCheckboxDemo2()
        {
            string expectedButtonText = "Uncheck All , Value = true";
            string actualResult = "Uncheck All , Value = true";

            Assert.AreEqual(expectedButtonText, actualResult);
        }

        [Test]
        public void MultipleCheckboxDemo3()
        {
            Assert()
        }







        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
