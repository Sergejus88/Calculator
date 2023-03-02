namespace SeleniumFrameWork.Pages.DemoQA
{
    public class Frames
    {
        public static void Open()
        {
            Driver.OpenUrl("https://demoqa.com/frames");
        }

        private static void SwitchToIframe()
        {
            string locator = "//*[@id='frame1']";
            Common.SwitchToIframe(locator);
        }

        public static string GetFrameHeadingText()
        {
            string locator = "//*[@id='sampleHeading']";
            SwitchToIframe();
            return Common.GetElementText(locator);
        }
    }
}
