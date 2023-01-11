using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrameworkStatic
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void Initialize()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("disable-notifications");
            //options.AddArgument("start-maximized");
            //options.AddArgument("headless");
            //options.AddArgument("window-size=1920,1080");


            driver = new ChromeDriver(options);
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenPage(string url)
        {
            driver.Url = url;
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}