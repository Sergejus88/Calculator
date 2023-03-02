using NUnit.Framework;
using SeleniumFrameWork;
using SeleniumFrameWork.Pages.SeleniumEasy;

[assembly: LevelOfParallelism(8)]
namespace SeleniumTests.SeleniumEasy
{
    [Parallelizable(scope: ParallelScope.Children)]
    internal class SimpleFormDemoTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            SimpleFormDemo.Open();
        }

        [Test]
        public void SingleInputField()
        {
            string expectedResult = "Test";

            SimpleFormDemo.EnterMessage(expectedResult);
            SimpleFormDemo.ClickShowMessageButton();
            string actualResult = SimpleFormDemo.GetSingleInputFieldMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("7", "5", "12")]
        [TestCase("7", "3", "10")]
        [TestCase("7", "2", "9")]
        [TestCase("7", "7", "14")]
        [TestCase("7", "8", "15")]
        [TestCase("7", "25", "32")]
        [TestCase("7", "5", "12")]
        [TestCase("7", "a", "NaN")]
        [TestCase("-11111111111111111111111", "11111111111111111111111", "0")]

        public void TwoInputFields(string inputAValue, string inputBValue, string expectedResult)
        {
            SimpleFormDemo.EnterInputA(inputAValue);
            SimpleFormDemo.EnterInputB(inputBValue);
            SimpleFormDemo.ClickGetTotalButton();
            string actualResult = SimpleFormDemo.GetTwoInputFieldsMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
