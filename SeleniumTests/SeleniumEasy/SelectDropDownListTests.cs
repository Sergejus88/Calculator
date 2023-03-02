using NUnit.Framework;
using SeleniumFrameWork;
using SeleniumFrameWork.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class SelectDropDownListTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            SelectDropDownList.Open();
        }

        [Test]
        public void SelectDay()
        {
            string expectedDay = "Tuesday";

            SelectDropDownList.SelectDay(expectedDay);
            string actualResult = SelectDropDownList.GetSelectedDay();

            Assert.IsTrue(actualResult.Contains(expectedDay));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
