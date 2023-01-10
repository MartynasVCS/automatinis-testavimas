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
        public void SimpleAlertConfirm()
        {
            string expectedResult = "I am an alert box!";

            JavascriptAlertBoxDemo.ClickAlertBoxButton();
            string actualResult = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.ConfirmAlert();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ConfirmBoxAlertConfirm()
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

        [Test]
        public void PromptBoxDefaultValueConfirm()
        {
            string expectedAlertText = "Please enter your name";
            string expectedMessage = "You have entered 'Enter name' !";

            JavascriptAlertBoxDemo.ClickPromptBoxButton();
            string actualAlertText = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.ConfirmAlert();
            string actualMessage = JavascriptAlertBoxDemo.GetPromptBoxMessage();

            Assert.AreEqual(expectedAlertText, actualAlertText);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void PromptBoxDefaultValueCancel()
        {
            string expectedAlertText = "Please enter your name";
            string expectedMessage = "";

            JavascriptAlertBoxDemo.ClickPromptBoxButton();
            string actualAlertText = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.CancelAlert();
            string actualMessage = JavascriptAlertBoxDemo.GetPromptBoxMessage();

            Assert.AreEqual(expectedAlertText, actualAlertText);
            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void PromptBoxCustomValueConfirm()
        {
            string expectedAlertText = "Please enter your name";
            string name = "Martynas";
            string expectedMessage = $"You have entered '{name}' !";

            JavascriptAlertBoxDemo.ClickPromptBoxButton();
            string actualAlertText = JavascriptAlertBoxDemo.GetAlertText();
            JavascriptAlertBoxDemo.EnterNameToPromptBox(name);
            JavascriptAlertBoxDemo.ConfirmAlert();
            string actualMessage = JavascriptAlertBoxDemo.GetPromptBoxMessage();

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
