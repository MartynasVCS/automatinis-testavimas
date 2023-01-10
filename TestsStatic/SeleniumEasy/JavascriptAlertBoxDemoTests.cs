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
        public void SimpleAlert()
        {
            string expectedResult = "I am an alert box!";

            JavascriptAlertBoxDemo.ClickAlertBoxButton();
            string actualResult = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.ConfirmAlert();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ConfirmBoxAlertOk()
        {
            string expectedAlertText = "Press a button!";
            string expectedMessage = "You pressed OK!";

            JavascriptAlertBoxDemo.ClickConfirmBoxButton();
            string actualAlertText = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.ConfirmAlert();
            string actualMessage = JavascriptAlertBoxDemo.GetConfirmBoxMessage();

            Assert.AreEqual(expectedAlertText, actualAlertText);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ConfirmBoxAlertCancel()
        {
            string expectedAlertText = "Press a button!";
            string expectedMessage = "You pressed Cancel!";

            JavascriptAlertBoxDemo.ClickConfirmBoxButton();
            string actualAlertText = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.CancelAlert();
            string actualMessage = JavascriptAlertBoxDemo.GetConfirmBoxMessage();

            Assert.AreEqual(expectedAlertText, actualAlertText);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
