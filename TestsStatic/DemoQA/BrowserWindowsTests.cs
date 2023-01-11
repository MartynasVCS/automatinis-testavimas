using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;
using TestsStatic.BaseClasses;

namespace TestsStatic.DemoQA
{
    internal class BrowserWindowsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BrowserWindows.Open();
        }

        [Test]
        public void Test()
        {
            string expectedHeadingText = "This is a sample page";

            BrowserWindows.ClickNewTabButton();
            string actualHeadingText = BrowserWindows.GetNewTabHeading();

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }
    }
}
