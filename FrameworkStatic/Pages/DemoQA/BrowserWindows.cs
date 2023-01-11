namespace FrameworkStatic.Pages.DemoQA
{
    public class BrowserWindows
    {
        private static string buttonNewTabLocator = "//*[@id='tabButton']";
        private static string headingNewTabLocator = "//*[@id='sampleHeading']";

        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/browser-windows");
        }

        public static void ClickNewTabButton()
        {
            Common.ClickElement(buttonNewTabLocator);

            string currentHandle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromParentWindowByHandle(currentHandle);
        }

        public static string GetNewTabHeading()
        {
            return Common.GetElementText(headingNewTabLocator);
        }
    }
}
