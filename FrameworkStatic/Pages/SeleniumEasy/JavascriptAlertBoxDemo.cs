namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class JavascriptAlertBoxDemo
    {
        private static string url = "https://demo.seleniumeasy.com/javascript-alert-box-demo.html";
        private static string sectionLocator = "//*[contains(@class,'panel-primary')]";
        private static string buttonAlertBoxLocator = $"({sectionLocator})[1]//button";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickAlertBoxButton()
        {
            Common.ClickElement(buttonAlertBoxLocator);
        }

        public static void ConfirmAlert()
        {
            Common.AcceptAlert();
        }

        public static string GetAlertText()
        {
            return Common.GetAlertText();
        }
    }
}
