using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestai
{
    public class Class1
    {
        [Test]
        public void Testas()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.google.com";
        }
    }
}
