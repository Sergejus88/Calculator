using NUnit.Framework;
using SeleniumFrameWork.Pages.DemoQA;
using SeleniumTests.BaseTests;

namespace SeleniumTests.DemoQA
{
    internal class FramesTests : BaseTest
    {
        [Test]
        public void Demo()
        {
            string expectedResult = "This is a sample page";

            Frames.Open();
            string actualResult = Frames.GetFrameHeadingText();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
