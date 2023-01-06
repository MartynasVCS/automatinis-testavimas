using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;

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

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
