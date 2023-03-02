using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace SeleniumFrameWork
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void SetupDriver(string userDataDir, string profileDir)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument($"user-data-dir={userDataDir}");
            options.AddArgument($"profile-directory={profileDir}");
            driver.Value = new ChromeDriver(options);
        }

        public static void SetupDriver()
        {
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
            //options.AddArgument("window-size=800,600");
            //options.AddArgument("start-maximized");
            driver.Value = new ChromeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void OpenUrl(string url)
        {
            // Su refresh
            driver.Value.Url = url;

            // Be refresh, išlaikom veiksmus kurie galėjo būti atlikti svetainėje
            //driver.Navigate().GoToUrl(url);
        }

        public static void CloseDriver()
        {
            driver.Value.Quit();
        }

        public static string TakeScreenshot(string methodName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            string screenshotName = $"{methodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.png";
            string screenshotFilePath = $"{screenshotsDirectoryPath}\\{screenshotName}";

            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            Directory.CreateDirectory(screenshotsDirectoryPath);
            screenshot.SaveAsFile(screenshotFilePath, ScreenshotImageFormat.Png);
            return screenshotFilePath;
        }
    }
}
