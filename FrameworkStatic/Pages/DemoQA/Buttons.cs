using System;

namespace FrameworkStatic.Pages.DemoQA
{
    public class Buttons
    {
        private static string url = "https://demoqa.com/buttons";
        private static string buttonDoubleClickLocator = "//*[@id='doubleClickBtn']";
        private static string buttonRightClickLocator = "//*[@id='rightClickBtn']";
        private static string buttonLeftClickLocator = "//*[text()='Click Me']";
        private static string messageDoubleClickLocator = "//*[@id='doubleClickMessage']";
        private static string messageRightClickLocator = "//*[@id='rightClickMessage']";
        private static string messageLeftClickLocator = "//*[@id='dynamicClickMessage']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void DoubleClickButton()
        {
            Common.DoubleClickElement(buttonDoubleClickLocator);
        }

        public static void RightClickButton()
        {
            Common.RightClickElement(buttonRightClickLocator);
        }

        public static void LeftClickButton()
        {
            Common.LeftClickElement(buttonLeftClickLocator);
        }

        public static string GetDoubleClickMessage()
        {
            return Common.GetElementText(messageDoubleClickLocator);
        }

        public static string GetRightClickMessage()
        {
            return Common.GetElementText(messageRightClickLocator);
        }

        public static string GetLeftClickMessage()
        {
            return Common.GetElementText(messageLeftClickLocator);
        }
    }
}
