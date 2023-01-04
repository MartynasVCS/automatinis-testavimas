using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTestai
{
    public class InputElements
    {
        [Test]
        public void DemoQaInput()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string expectedOutput = "Labas";

            IWebElement inputElement = driver.FindElement(By.XPath("//*[@id='userName']"));
            inputElement.SendKeys(expectedOutput);
            string actualOutput = inputElement.GetAttribute("value");

            Assert.AreEqual(expectedOutput, actualOutput);

            driver.Quit();
        }

        [Test]
        public void DemoQaTextBox()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";
            
            string expectedResult = "Text Box";

            IWebElement inputElement = driver.FindElement(By.XPath("//*[@class='main-header']"));
            string actualResult = inputElement.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void OmayoBlogspotInput()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://omayo.blogspot.com/";

            string expectedResult = "Martynas";

            IWebElement inputElement = driver.FindElement(By.XPath("//*[@name='form1']/input[@type='text']"));
            inputElement.SendKeys(expectedResult);
            string actualResult = inputElement.GetAttribute("value");

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void OmayoBlogspotInputWithClear()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://omayo.blogspot.com/";

            string expectedResult = "Martynas";

            IWebElement inputElement = driver.FindElement(By.XPath("//*[@id='textbox1']"));
            inputElement.Clear();
            inputElement.SendKeys(expectedResult);
            string actualResult = inputElement.GetAttribute("value");

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void SeleniumEasySingleInputFieldValueOnly()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string expectedResult = "Martynas";

            IWebElement inputMessage = driver.FindElement(By.XPath("//*[@id='user-message']"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            IWebElement spanMessage = driver.FindElement(By.XPath("//*[@id='display']"));

            inputMessage.SendKeys(expectedResult);
            buttonShowMessage.Click();
            string actualResult = spanMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void SeleniumEasySingleInputFieldFullMessage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string message = "Martynas";
            string expectedResult = $"Your Message: {message}";

            IWebElement inputMessage = driver.FindElement(By.XPath("//input[@id='user-message']"));
            IWebElement buttonShowMessage = driver.FindElement(By.XPath("//*[@id='get-input']/button"));
            IWebElement fullMessage = driver.FindElement(By.XPath("//div[@id='user-message']"));

            inputMessage.SendKeys(message);
            buttonShowMessage.Click();
            string actualResult = fullMessage.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void SeleniumEasyTwoInputFields()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string valueInputA = "3";
            string valueInputB = "4";
            string expectedResult = "7";

            IWebElement inputA = driver.FindElement(By.Id("sum1"));
            IWebElement inputB = driver.FindElement(By.Id("sum2"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            IWebElement spanTotal = driver.FindElement(By.XPath("//*[@id='displayvalue']"));

            inputA.SendKeys(valueInputA);
            inputB.SendKeys(valueInputB);
            buttonGetTotal.Click();
            string actualResult = spanTotal.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }

        [Test]
        public void SeleniumEasyTwoInputFieldsNaN()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.seleniumeasy.com/basic-first-form-demo.html";

            string expectedResult = "NaN";

            IWebElement inputA = driver.FindElement(By.Id("sum1"));
            IWebElement inputB = driver.FindElement(By.Id("sum2"));
            IWebElement buttonGetTotal = driver.FindElement(By.XPath("//*[@id='gettotal']/button"));
            IWebElement spanTotal = driver.FindElement(By.XPath("//*[@id='displayvalue']"));

            buttonGetTotal.Click();
            string actualResult = spanTotal.Text;

            Assert.AreEqual(expectedResult, actualResult);

            driver.Quit();
        }
    }
}
