using System.Collections.Generic;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicSelectDropdownDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-select-dropdown-demo.html";
        private static string selectElementLocator = "//*[@id='select-demo']";
        private static string messageWeekDayLocator = "//*[@class='selected-value']";
        private static string multiSelectElementLocator = "//*[@id='multi-select']";
        private static string buttonGetAllSelectedLocator = "//*[@id='printAll']";
        private static string multiSelectMessageLocator = "//*[@class='getall-selected']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void SelectWeekday(string weekDay)
        {
            Common.SelectOptionByValue(selectElementLocator, weekDay);
        }

        public static string GetDaySelectedMessage()
        {
            return Common.GetElementText(messageWeekDayLocator);
        }

        public static void SelectMultipleOptionsByText(List<string> selectionValues)
        {
            Common.SelectMultipleOptionsByText(multiSelectElementLocator, selectionValues);
        }

        public static void ClickGetAllSelectedButton()
        {
            Common.ClickElement(buttonGetAllSelectedLocator);
        }

        public static string GetMultiSelectMessage()
        {
            return Common.GetElementText(multiSelectMessageLocator);
        }

        private static List<string> GenerateOptionElementLocatorList(List<string> optionTextList)
        {
            List<string> locators = new List<string>();
            foreach (string optionText in optionTextList)
            {
                locators.Add($"//*[text()='{optionText}']");
            }
            return locators;
        }

        public static void SelectMultipleOptionsByTextUsingActions(List<string> selectionValues)
        {
            List<string> optionElementLocatorList = GenerateOptionElementLocatorList(selectionValues);
            Common.SelectMultipleOptionsByTextUsingActions(multiSelectElementLocator, optionElementLocatorList);
        }
    }
}