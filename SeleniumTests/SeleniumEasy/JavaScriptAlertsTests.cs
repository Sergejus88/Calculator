using NUnit.Framework;
using SeleniumFrameWork;
using SeleniumFrameWork.Pages.SeleniumEasy;

namespace SeleniumTests.SeleniumEasy
{
    internal class JavaScriptAlerts
    {
        [SetUp]
        public void Setup()
        {
            Driver.SetupDriver();
            JavascriptAlerts.Open();
        }

        [Test]
        public void TestJavascriptAlerts()
        {
            string expectedValue = "I am an alert box!";

            JavascriptAlerts.OpenSimpleAlert();
            string actualValue = JavascriptAlerts.GetAlertText();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
