using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;

namespace FrameworkStatic
{
    public class Driver
    {
        private static ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();

        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-notifications");
            //options.AddArgument("start-maximized");
            //options.AddArgument("headless");
            //options.AddArgument("window-size=1920,1080");


            driver.Value = new ChromeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver.Value;
        }

        public static void OpenPage(string url)
        {
            driver.Value.Url = url;
        }

        public static void CloseDriver()
        {
            driver.Value.Quit();
        }

        public static void TakeScreenshot(string testMethodName)
        {
            string screenshotsDirectoryPath = $"{AppDomain.CurrentDomain.BaseDirectory}screenshots";
            //string screenshotName = $"{screenshotsDirectoryPath}\\scr-{Guid.NewGuid()}.png";
            string screenshotName = $"{screenshotsDirectoryPath}\\scr-{testMethodName}-{DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss")}.png";

            Directory.CreateDirectory(screenshotsDirectoryPath);
            Screenshot screenshot = ((ITakesScreenshot)driver.Value).GetScreenshot();
            screenshot.SaveAsFile(screenshotName, ScreenshotImageFormat.Png);
        }
    }
}