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
        public void OldStyleSelectMenuDropdown()
        {
            string expectedColor = "Purple";

            SelectMenu.SelectColor(expectedColor);
            string actualColor = SelectMenu.GetSelectedColor();

            Assert.AreEqual(expectedColor, actualColor);
        }

        [Test]
        public void SelectValueDropdown()
        {
            string expectedSelection = "Group 2, option 1";

            SelectMenu.ExpandSelectValueDropdown();
            SelectMenu.SelectValueFromSelectValueDropdown(expectedSelection);
            string actualSelection = SelectMenu.GetSelectedValueOfSelectValueDropdown();

            Assert.AreEqual(expectedSelection, actualSelection);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
