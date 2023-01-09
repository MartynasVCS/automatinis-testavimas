using System;

namespace FrameworkStatic.Pages.DemoQA
{
    public class DynamicProperties
    {
        private static string url = "https://demoqa.com/dynamic-properties";
        private static string buttonToBeClickableLocator = "//*[@id='enableAfter']";
        private static string buttonToChangeColorLocator = "//*[@id='colorChange']";
        private static string buttonToBePresentLocator = "//*[@id='visibleAfter']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void WaitForButtonToBeClickable()
        {
            Common.WaitForElementToBeClickable(buttonToBeClickableLocator);
        }

        public static void WaitForButtonToChangeColor()
        {
            Common.WaitForElementAttributeToContainValue(buttonToChangeColorLocator, "class", "text-danger");
        }

        public static void WaitForButtonToBePresent()
        {
            Common.WaitForElementToBeVisible(buttonToBePresentLocator);
        }
    }
}
