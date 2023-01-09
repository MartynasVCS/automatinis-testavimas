using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;

namespace TestsStatic.DemoQA
{
    internal class SelectMenuTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            SelectMenu.Open();
        }

        [Test]
        public void OldStyleSelectMenuByText()
        {
            string expectedColor = "Purple";

            SelectMenu.SelectColor(expectedColor);
            string actualColor = SelectMenu.GetSelectedColor();

            Assert.AreEqual(expectedColor, actualColor);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
