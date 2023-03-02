using NUnit.Framework;
using SeleniumTests.BaseTests;

namespace SeleniumTests.Ignitis
{
    internal class HomePageTests : BaseTestChromeProfile
    {
        [Test]
        public void OpenHomePage()
        {
            string expectedTitle = "Kuriame energetiškai sumanų pasaulį | Ignitis";

            HomePage.Open();
            string actualTitle = HomePage.WaitForTitleToBe(expectedTitle);

            Assert.AreEqual(expectedTitle, actualTitle);
        }
    }
}
