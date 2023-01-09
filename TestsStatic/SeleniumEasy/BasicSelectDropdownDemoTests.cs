using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicSelectDropdownDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            BasicSelectDropdownDemo.Open();
        }

        [Test]
        public void SelectDropdown()
        {
            string expectedDay = "Sunday";

            BasicSelectDropdownDemo.SelectWeekday(expectedDay);
            string result = BasicSelectDropdownDemo.GetDaySelectedMessage();

            Assert.IsTrue(result.Contains(expectedDay));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
