namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicCheckboxDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-checkbox-demo.html";
        private static string singleCheckboxLocator = "//*[@id='isAgeSelected']";
        private static string successMessageLocator = "//*[@id='txtAge']";

        public static void Open()
        {
            Driver.OpenPaqe(url);
        }

        public static void ClickSingleCheckbox()
        {
            Common.ClickElement(singleCheckboxLocator);
        }

        public static string GetSuccessMessage()
        {
            return Common.GetElementText(successMessageLocator);
        }
    }
}
