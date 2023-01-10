using System;

namespace FrameworkStatic.Pages.DemoQA
{
    public class SelectMenu
    {
        private static string url = "https://demoqa.com/select-menu";
        private static string selectElementLocator = "//*[@id='oldSelectMenu']";
        private static string selectValueDropdownLocator = "//*[@id='withOptGroup']";
        private static string selectionOfSelectValueDropdownLocator = $"{selectValueDropdownLocator}/div/div[1]/div[1]";

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

        public static void ExpandSelectValueDropdown()
        {
            Common.ClickElement(selectValueDropdownLocator);
        }

        public static void SelectValueFromSelectValueDropdown(string value)
        {
            string optionByTextLocator = $"//*[text()='{value}']";
            Common.ClickElement(optionByTextLocator);
        }

        public static string GetSelectedValueOfSelectValueDropdown()
        {
            return Common.GetElementText(selectionOfSelectValueDropdownLocator);
        }
    }
}
