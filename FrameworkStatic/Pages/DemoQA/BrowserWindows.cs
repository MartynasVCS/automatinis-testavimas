namespace FrameworkStatic.Pages.DemoQA
{
    public class BrowserWindows
    {
        private static string buttonNewTabLocator = "//*[@id='tabButton']";
        private static string buttonNewWindowLocator = "//*[@id='windowButton']";
        private static string headingNewTabLocator = "//*[@id='sampleHeading']";

        public static void Open()
        {
            Driver.OpenPage("https://demoqa.com/browser-windows");
        }

        private static void SwitchWindowFromCurrent()
        {
            string currentHandle = Common.GetCurrentWindowHandle();
            Common.SwitchToNewWindowFromParentWindowByHandle(currentHandle);
        }

        public static void ClickNewTabButton()
        {
            Common.ClickElement(buttonNewTabLocator);
            SwitchWindowFromCurrent();
        }

        public static void ClickNewWindowButton()
        {
            Common.ClickElement(buttonNewWindowLocator);
            SwitchWindowFromCurrent();
        }

        public static string GetNewTabHeading()
        {
            return Common.GetElementText(headingNewTabLocator);
        }
    }
}
