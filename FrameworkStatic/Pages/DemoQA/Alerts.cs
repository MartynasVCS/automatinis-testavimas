using System;

namespace FrameworkStatic.Pages.DemoQA
{
    public class Alerts
    {
        private static string url = "https://demoqa.com/alerts";
        private static string buttonPromptBoxLocator = "//*[@id='promtButton']";
        private static string messageElementLocator = "//*[@id='promptResult']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickPromptBoxButton()
        {
            Common.ClickElement(buttonPromptBoxLocator);
        }

        public static bool CheckIfMessageElementIsPresent()
        {
            return Common.CheckIfElementIsPresent(messageElementLocator);
        }

        public static void CancelAlert()
        {
            Common.DismissAlert();
        }
    }
}
