using System;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class JavascriptAlertBoxDemo
    {
        private static string url = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";
        private static string sectionLocator = "//*[contains(@class,'panel-primary')]";
        private static string buttonAlertBoxLocator = $"({sectionLocator})[1]//button";
        private static string buttonConfirmBoxLocator = $"({sectionLocator})[2]//button";
        private static string buttonPromptBoxLocator = $"({sectionLocator})[3]//button";
        private static string messageConfirmBoxLocator = "//*[@id='confirm-demo']";
        private static string messagePromptBoxLocator = "//*[@id='prompt-demo']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickAlertBoxButton()
        {
            Common.ClickElement(buttonAlertBoxLocator);
        }

        public static void ClickConfirmBoxButton()
        {
            Common.ClickElement(buttonConfirmBoxLocator);
        }
        public static void ClickPromptBoxButton()
        {
            Common.ClickElement(buttonPromptBoxLocator);
        }

        public static string GetConfirmBoxMessage()
        {
            return Common.GetElementText(messageConfirmBoxLocator);
        }

        public static string GetPromptBoxMessage()
        {
            return Common.GetElementText(messagePromptBoxLocator);
        }

        public static void ConfirmAlert()
        {
            Common.AcceptAlert();
        }

        public static void EnterNameToPromptBox(string name)
        {
            Common.SendKeysToAlert(name);
        }

        public static void CancelAlert()
        {
            Common.DismissAlert();
        }

        public static string GetAlertText()
        {
            return Common.GetAlertText();
        }
    }
}
