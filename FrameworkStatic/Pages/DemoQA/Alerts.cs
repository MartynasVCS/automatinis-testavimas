using System;

namespace FrameworkStatic.Pages.DemoQA
{
    public class Alerts
    {
        private static string url = "https://demoqa.com/alerts";
        private static string buttonPromptBoxLocator = "//*[@id='promtButton']";
        private static string messageElementLocator = "//*[@id='promptResult']";
        private static string buttonAlertWithDelayLocator = "//*[@id='timerAlertButton']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickAlertWithDelayButton()
        {
            Common.ClickElement(buttonAlertWithDelayLocator);
        }

        public static void ClickPromptBoxButton()
        {
            Common.ClickElement(buttonPromptBoxLocator);
        }

        public static bool CheckIfMessageElementIsPresent()
        {
            return Common.CheckIfElementIsPresent(messageElementLocator);
        }

        public static void ConfirmAlert()
        {
            Common.WaitForAlertToBePresent();
            Common.AcceptAlert();
        }

        public static void CancelAlert()
        {
            Common.DismissAlert();
        }

        public static bool CheckIfAlertIsPresent()
        {
            return Common.CheckIfAlertIsPresent();
        }
    }
}
