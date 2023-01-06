using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;

namespace TestsStatic.DemoQA
{
    internal class DynamicPropertiesTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            DynamicProperties.Open();
        }

        [Test]
        public void WaitForButtonToBeClickable()
        {
            DynamicProperties.WaitForButtonToBeClickable();
        }

        [Test]
        public void WaitForButtonToChangeColor()
        {
            DynamicProperties.WaitForButtonToChangeColor();
        }

        [Test]
        public void WaitForButtonToBePresent()
        {
            DynamicProperties.WaitForButtonToBePresent();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
