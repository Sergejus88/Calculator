using NUnit.Framework;
using SeleniumFrameWork.Pages.SeleniumEasy;
using SeleniumFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumFrameWork.Pages.DemoQA;

namespace SeleniumTests.DemoQA
{
    internal class DynamicPropertiesTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
            CheckBoxDemo.Open();
        }

        [Test]
        public void WaitForButtonToBeClickable()
        {  
            Assert.IsTrue(DynamicProperties.WaitForButtonToBeClickable());
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
