using NUnit.Framework.Interfaces;
using NUnit.Framework;
using SeleniumFrameWork;
namespace SeleniumTests.BaseTests
{
    internal class BaseTestSingleSession
    {
        [OneTimeSetUp]
        public void SetUp()
        {
            Driver.SetupDriver();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                string fileName = Driver.TakeScreenshot(TestContext.CurrentContext.Test.MethodName);
                TestContext.AddTestAttachment(fileName);
            }
            Driver.CloseDriver();
        }
    }
}
