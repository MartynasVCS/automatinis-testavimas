using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;

namespace TestsStatic.DemoQA
{
    internal class ButtonsTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            Buttons.Open();
        }

        [Test]
        public void PerformLeftClick()
        {
            string expectedMessage = "You have done a dynamic click";

            Buttons.LeftClickButton();
            string actualMessage = Buttons.GetLeftClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void PerformDoubleClick()
        {
            string expectedMessage = "You have done a double click";

            Buttons.DoubleClickButton();
            string actualMessage = Buttons.GetDoubleClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [Test]
        public void PerformRightClick()
        {
            string expectedMessage = "You have done a right click";

            Buttons.RightClickButton();
            string actualMessage = Buttons.GetRightClickMessage();

            Assert.AreEqual(expectedMessage, actualMessage);
        }

        [TearDown] public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
