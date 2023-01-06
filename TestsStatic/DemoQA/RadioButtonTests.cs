using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;

namespace TestsStatic.DemoQA
{
    internal class RadioButtonTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            RadioButton.Open();
        }

        [Test] 
        public void ClickRadioButtonYes()
        {
            string expectedMessage = "Yes";

            RadioButton.ClickRadioButtonYes();
            string actualMessage = RadioButton.GetMessageSelectedText();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void ClickRadioButtonImpressive()
        {
            string expectedMessage = "Impressive";

            RadioButton.ClickRadioButtonImpressive();
            string actualMessage = RadioButton.GetMessageSelectedText();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void CheckThatRadioButtonNoIsDisabled()
        {
            bool radioNoEnabled = RadioButton.CheckIfRadioButtonNoIsEnabled();

            Assert.AreEqual(false, radioNoEnabled);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
