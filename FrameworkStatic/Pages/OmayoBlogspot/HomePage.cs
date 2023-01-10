using System;
using System.IO;

namespace FrameworkStatic.Pages.OmayoBlogspot
{
    public class HomePage
    {
        private static string url = "https://omayo.blogspot.com/";
        private static string htmlFormUserNameLocator = "//*[@name='form1']/input[@type='text']";
        private static string textBoxWithPreloadedTextLocator = "//*[@id='textbox1']";
        private static string inputFileUploadLocator = "//*[@id='uploadfile']";

        public static void Open()
        {
            Driver.OpenPage(url);
        }

        public static void EnterHtmlFormUserName(string name)
        {
            Common.SendKeysToElement(htmlFormUserNameLocator, name);
        }

        public static string GetValueOfHtmlFormUserName()
        {
            return Common.GetAttributeValue(htmlFormUserNameLocator, "value");
        }

        public static void ClearTextBoxWithPreloadedText()
        {
            Common.ClearInputElement(textBoxWithPreloadedTextLocator);
        }

        public static void EnterToTextBoxWithPreloadedText(string text)
        {
            Common.SendKeysToElement(textBoxWithPreloadedTextLocator, text);
        }

        public static string GetValueOfTextBoxWithPreloadedText()
        {
            return Common.GetAttributeValue(textBoxWithPreloadedTextLocator, "value");
        }

        public static void SetFileForUpload()
        {
            string currentDirectoryPath = Directory.GetCurrentDirectory();
            string solutionDirectoryPath = Directory.GetParent(currentDirectoryPath).Parent.Parent.FullName;
            string demoFilePath = $"{solutionDirectoryPath}/FrameworkStatic/Driver.cs";
            Common.SendKeysToElement(inputFileUploadLocator, demoFilePath);
        }

        public static string GetSelectedFileName()
        {
            return Common.GetAttributeValue(inputFileUploadLocator, "value");
        }
    }
}