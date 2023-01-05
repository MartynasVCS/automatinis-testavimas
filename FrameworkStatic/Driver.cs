using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrameworkStatic
{
    public class Driver
    {
        private static IWebDriver driver;

        public static void Initialize()
        {
            driver = new ChromeDriver();
        }

        public static IWebDriver GetDriver()
        {
            return driver;
        }

        public static void OpenPaqe(string url)
        {
            driver.Url = url;
        }

        public static void CloseDriver()
        {
            driver.Quit();
        }
    }
}