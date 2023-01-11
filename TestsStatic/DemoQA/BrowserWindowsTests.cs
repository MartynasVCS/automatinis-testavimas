using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;
using TestsStatic.BaseClasses;

namespace TestsStatic.DemoQA
{
    [Parallelizable(scope: ParallelScope.Children)]
    internal class BrowserWindowsTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BrowserWindows.Open();
        }

        [Test]
        public void NewTab()
        {
            string expectedHeadingText = "This is a sample page";

            BrowserWindows.ClickNewTabButton();
            string actualHeadingText = BrowserWindows.GetNewTabHeading();

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }

        [Test]
        public void NewWindow()
        {
            string expectedHeadingText = "This is a sample page";

            BrowserWindows.ClickNewWindowButton();
            string actualHeadingText = BrowserWindows.GetNewTabHeading();

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }
    }
}
