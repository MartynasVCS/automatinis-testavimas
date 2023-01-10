using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;

namespace TestsStatic.SeleniumEasy
{
    internal class JavascriptAlertBoxDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            JavascriptAlertBoxDemo.Open();
        }

        [Test]
        public void TestSimpleAlert()
        {
            string expectedResult = "I am an alert box!";

            JavascriptAlertBoxDemo.ClickAlertBoxButton();
            string actualResult = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.ConfirmAlert();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
