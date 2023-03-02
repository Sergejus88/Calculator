using NUnit.Framework;
using SeleniumFrameWork;

namespace SeleniumTests.SeleniumEasy
{
    internal class SelectDropDownListTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            SelectDropdownList.Open();
        }

        [Test]
        public void SelectDay()
        {
            string expectedDay = "Tuesday";

            SelectDropdownList.SelectDay(expectedDay);
            string actualResult = SelectDropdownList.GetSelectedDay();

            Assert.IsTrue(actualResult.Contains(expectedDay));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
