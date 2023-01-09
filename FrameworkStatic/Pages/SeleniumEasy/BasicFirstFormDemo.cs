namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicFirstFormDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";
        private static string inputMessageLocator = "//*[@id='user-message']";
        private static string buttonShowMessageLocator = "//*[@id='get-input']/button";
        private static string spanMessageLocator = "//*[@id='display']";
        private static string divFullMessageLocator = "//div[@id='user-message']";
        private static string inputValueALocator = "//*[@id='sum1']";
        private static string inputValueBLocator = "//*[@id='sum2']";
        private static string buttonGetTotalLocator = "//*[@id='gettotal']/button";
        private static string spanTotalLocator = "//*[@id='displayvalue']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void EnterMessage(string message)
        {
            Common.SendKeysToElement(inputMessageLocator, message);
        }

        public static void ClickShowMessageButton()
        {
            Common.ClickElement(buttonShowMessageLocator);
        }

        public static string GetValueOfMessage()
        {
            return Common.GetElementText(spanMessageLocator);
        }

        public static string GetValueOfFullMessage()
        {
            return Common.GetElementText(divFullMessageLocator);
        }

        public static void EnterValueA(string value)
        {
            Common.SendKeysToElement(inputValueALocator, value);
        }

        public static void EnterValueB(string value)
        {
            Common.SendKeysToElement(inputValueBLocator, value);
        }

        public static void ClickGetTotalButton()
        {
            Common.ClickElement(buttonGetTotalLocator);
        }

        public static string GetValueOfTotal()
        {
            return Common.GetElementText(spanTotalLocator);
        }
    }
}