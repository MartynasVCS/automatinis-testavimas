namespace FrameworkStatic.Pages.DemoQA
{
    public class Frames
    {
        private static string iframe1Locator = "//*[@id='frame1']";
        private static string headingIframe1Locator = "//*[@id='sampleHeading']";

        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/frames");
        }

        private static void SwitchToIframeByElement(string iframeElementLocator)
        {
            Common.SwitchToIframeByLocator(iframe1Locator);
        }

        public static string GetIframeHeadingText()
        {
            SwitchToIframeByElement(iframe1Locator);
            return Common.GetElementText(headingIframe1Locator);
        }
    }
}
