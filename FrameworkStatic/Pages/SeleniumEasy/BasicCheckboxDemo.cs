namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicCheckboxDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-checkbox-demo.html";
        private static string singleCheckboxLocator = "//*[@id='isAgeSelected']";
        private static string successMessageLocator = "//*[@id='txtAge']";
        private static string multipleCheckboxesLocator = "//*[@class='cb1-element']";
        private static string buttonMultipleCheckboxes = "//*[@id='check1']";
        private static string checkbox1Locator = "(//*[@class='cb1-element'])[1]";
        private static string checkbox2Locator = "(//*[@class='cb1-element'])[2]";
        private static string checkbox3Locator = "(//*[@class='cb1-element'])[3]";
        private static string checkbox4Locator = "(//*[@class='cb1-element'])[4]";

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

        public static void ClickEachCheckbox()
        {
            Common.ClickMultipleElements(multipleCheckboxesLocator);
        }

        public static string GetButtonText()
        {
            return Common.GetAttributeValue(buttonMultipleCheckboxes, "value");
        }

        public static void ClickButtonCheckAll()
        {
            Common.ClickElement(buttonMultipleCheckboxes);
        }

        public static bool GetCheckbox1Status()
        {
            return Common.GetElementSelectedStatus(checkbox1Locator);
        }

        public static bool GetCheckbox2Status()
        {
            return Common.GetElementSelectedStatus(checkbox2Locator);
        }

        public static bool GetCheckbox3Status()
        {
            return Common.GetElementSelectedStatus(checkbox3Locator);
        }

        public static bool GetCheckbox4Status()
        {
            return Common.GetElementSelectedStatus(checkbox4Locator);
        }
    }
}
