namespace SeleniumFrameWork.Pages.Ignitis
{
    public  class HomePage
    {
        public static void Open()
        {
            Driver.OpenUrl("https://ignitis.lt");
        }

        public static string WaitForTitleToBe(string expectedTitle)
        {
            Common.WaitForTitleToBe(expectedTitle);
            return Driver.GetDriver().Title;
        }
    }
}
