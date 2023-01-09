using System;

namespace FrameworkStatic.Pages.DemoQA
{
    public class SelectMenu
    {
        private static string url = "https://demoqa.com/select-menu";
        private static string selectElementLocator = "//*[@id='oldSelectMenu']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void SelectColor(string expectedColor)
        {
            Common.SelectOptionByText(selectElementLocator, expectedColor);
        }

        public static string GetSelectedColor()
        {
            return Common.GetSelectedOptionText(selectElementLocator);
        }
    }
}
