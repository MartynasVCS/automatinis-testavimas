using System;

namespace FrameworkStatic.Pages.SeleniumEasy
{
    public class BasicRadioButtonDemo
    {
        private static string url = "https://demo.seleniumeasy.com/basic-radiobutton-demo.html";
        private static string singleRadioButtonSectionLocator = "//*[text()='Radio Button Demo']/following-sibling::div";
        private static string singleRadioMaleLocator = $"{singleRadioButtonSectionLocator}//input[@value='Male']/..";
        private static string buttonGetCheckedValueLocator = $"{singleRadioButtonSectionLocator}//button";
        private static string responseSingleRadioButtonLocator = $"{singleRadioButtonSectionLocator}//p[@class='radiobutton']";
        private static string groupRadioMaleButtonLocator = "//input[@name='gender' and @value='Male']/..";
        private static string groupRadioAgeGroup5To15ButtonLocator = "//input[@value='5 - 15']";
        private static string buttonGetValuesLocator = "//button[text()='Get values']";
        private static string responseGroupRadioButtonLocator = "//*[@class='groupradiobutton']";

        public static void Open()
        {
            Driver.OpenPaqe(url);
        }

        public static void ClickSingleRadioMaleButton()
        {
            Common.ClickElement(singleRadioMaleLocator);
        }

        public static void ClickGetCheckedValueButton()
        {
            Common.ClickElement(buttonGetCheckedValueLocator);
        }

        public static string GetSingleRadioButtonResponseMessage()
        {
            return Common.GetElementText(responseSingleRadioButtonLocator);
        }

        public static void ClickGroupRadioMaleButton()
        {
            Common.ClickElement(groupRadioMaleButtonLocator);
        }

        public static void ClickGroupRadioAgeGroup5To15Button()
        {
            Common.ClickElement(groupRadioAgeGroup5To15ButtonLocator);
        }

        public static void ClickGetValuesButton()
        {
            Common.ClickElement(buttonGetValuesLocator);
        }

        public static string GetGroupRadioButtonResponseMessage()
        {
            return Common.GetElementText(responseGroupRadioButtonLocator);
        }
    }
}