using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFrameWork.Pages.SeleniumEasy
{
    internal class LoadingTests
    {
        private bool FirstNameLastName;

        public static bool WaitForElementToBeVisible()
        {
            string FirstNameLastName = "//*[@id='save']";
            string locator = "//*[@id='save']";
            Common.WaitForElementToBeVisible(locator);
            return Common.CheckIfElementIsVisible(locator);
        }

        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            LoadingTests.("https://demo.seleniumeasy.com/dynamic-data-loading-demo.html");
        }

        [Test]
        public void Test4()
        {
            LoadingTests.WaitForElementToBeVisible();
            Assert.IsTrue(FirstNameLastName);
            Assert.IsTrue(LoadingTests.WaitForElementToBeVisible());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}

