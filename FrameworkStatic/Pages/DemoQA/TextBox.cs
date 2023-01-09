namespace FrameworkStatic.Pages.DemoQA
{
    public class TextBox
    {
        public static void Open()
        {
            string url = "https://demoqa.com/text-box";
            Driver.OpenPage(url);
        }

        public static string GetHeaderText()
        {
            string locator = "//*[@class='main-header']";
            return Common.GetElementText(locator);
        }

        public static void EnterFullName(string name)
        {
            string locator = "//*[@id='userName']";
            Common.SendKeysToElement(locator, name);
        }
    }
}