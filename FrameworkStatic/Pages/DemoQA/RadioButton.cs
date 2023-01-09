using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkStatic.Pages.DemoQA
{
    public class RadioButton
    {
        private static string url = "https://demoqa.com/radio-button";
        private static string radioYesLocator = "//*[@for='yesRadio']";
        private static string radioImpressiveLocator = "//*[@for='impressiveRadio']";
        private static string radioNoLocator = "//*[@id='noRadio']";
        private static string spanTextSuccessLocator = "//*[@class='text-success']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void ClickRadioButtonYes()
        {
            Common.ClickElement(radioYesLocator);
        }

        public static void ClickRadioButtonImpressive()
        {
            Common.ClickElement(radioImpressiveLocator);
        }

        public static string GetMessageSelectedText()
        {
            return Common.GetElementText(spanTextSuccessLocator);
        }

        public static bool CheckIfRadioButtonNoIsEnabled()
        {
            return Common.GetElementEnabledStatus(radioNoLocator);
        }
    }
}
