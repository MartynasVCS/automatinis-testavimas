using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;

namespace TestsStatic.DemoQA
{
    internal class AlertsTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Alerts.Open();
        }

        [Test]
        public void PromtBoxDefaultValueCancel()
        {
            bool messageElementIsPresent = false;

            Alerts.ClickPromptBoxButton();
            Alerts.CancelAlert();
            bool messageElementActualPresence = Alerts.CheckIfMessageElementIsPresent();

            Assert.AreEqual(messageElementIsPresent, messageElementActualPresence);
        }

        [Test]
        public void AlertBoxWithDelay()
        {
            bool expectedAlertPresence = false;

            Alerts.ClickAlertWithDelayButton();
            Alerts.ConfirmAlert();
            bool actualAlertPresence = Alerts.CheckIfAlertIsPresent();

            Assert.AreEqual(expectedAlertPresence, actualAlertPresence);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
