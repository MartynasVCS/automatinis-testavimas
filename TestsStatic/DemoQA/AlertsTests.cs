using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;
using TestsStatic.BaseClasses;

namespace TestsStatic.DemoQA
{
    internal class AlertsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
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
    }
}
