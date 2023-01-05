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

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
