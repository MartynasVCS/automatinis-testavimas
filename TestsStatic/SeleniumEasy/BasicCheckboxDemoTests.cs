using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicCheckboxDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            BasicCheckboxDemo.Open();
        }

        [Test]
        public void ClickSingleCheckbox()
        {
            string expectedMessage = "Success - Check box is checked";

            BasicCheckboxDemo.ClickSingleCheckbox();
            string actualMessage = BasicCheckboxDemo.GetSuccessMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ClickMultipleCheckboxes()
        {
            string expectedButtonText = "Uncheck All";

            BasicCheckboxDemo.ClickEachCheckbox();
            string actualButtonText = BasicCheckboxDemo.GetButtonText();

            Assert.AreEqual(expectedButtonText, actualButtonText);
        }

        [Test]
        public void CheckIfMultipleCheckboxesAreSelected()
        {
            BasicCheckboxDemo.ClickButtonCheckAll();
            bool checkbox1Status = BasicCheckboxDemo.GetCheckbox1Status();
            bool checkbox2Status = BasicCheckboxDemo.GetCheckbox2Status();
            bool checkbox3Status = BasicCheckboxDemo.GetCheckbox3Status();
            bool checkbox4Status = BasicCheckboxDemo.GetCheckbox4Status();

            Assert.AreEqual(true, checkbox1Status);
            Assert.AreEqual(true, checkbox2Status);
            Assert.AreEqual(true, checkbox3Status);
            Assert.AreEqual(true, checkbox4Status);
        }

        [Test]
        public void CheckIfMultipleCheckboxesAreSelectedUsingLoop()
        {
            // 1 budas naudojant loop 

            List<bool> statuses = BasicCheckboxDemo.GetStatusOfAllCheckboxes();

            foreach (bool status in statuses)
            {
                Assert.AreEqual(false, status);
            }

            // 2 budas. Kreivas!!! Kodėl? Žiūrėti paskaitos įrašą

            Assert.AreEqual(false, BasicCheckboxDemo.CheckIfAllCheckboxesAreSelected());
            BasicCheckboxDemo.ClickButtonCheckAll();
            Assert.AreEqual(true, BasicCheckboxDemo.CheckIfAllCheckboxesAreSelected());
        }

        [Test]
        public void ClickMultipleCheckboxesWithIntermediaryButtonTextChecks()
        {
            string buttonTextUncheck = "Uncheck All";
            string buttonTextCheck = "Check All";

            BasicCheckboxDemo.ClickCheckbox1();
            string actualButtonText = BasicCheckboxDemo.GetButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            BasicCheckboxDemo.ClickCheckbox2();
            actualButtonText = BasicCheckboxDemo.GetButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            BasicCheckboxDemo.ClickCheckbox3();
            actualButtonText = BasicCheckboxDemo.GetButtonText();
            Assert.AreEqual(buttonTextCheck, actualButtonText);

            BasicCheckboxDemo.ClickCheckbox4();
            actualButtonText = BasicCheckboxDemo.GetButtonText();
            Assert.AreEqual(buttonTextUncheck, actualButtonText);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
