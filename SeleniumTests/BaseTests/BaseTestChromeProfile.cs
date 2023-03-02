using NUnit.Framework;
using SeleniumFrameWork;

namespace SeleniumTests.BaseTests
{
    internal class BaseTestChromeProfile
    {
        [SetUp]
        public void SetUp()
        {
            string userDataDir = "C:\\Users\\Martynas\\AppData\\Local\\Google\\Chrome\\User Data";
            string profileDir = "Profile 3";
            Driver.SetupDriver(userDataDir, profileDir);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        } 
    }
}
