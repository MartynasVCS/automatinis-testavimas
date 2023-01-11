using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;
using TestsStatic.BaseClasses;

namespace TestsStatic.DemoQA
{
    internal class FramesTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            Frames.Open();
        }

        [Test]
        public void ReadHeadingInsideIframe()
        {
            string expectedHeadingText = "This is a sample page";

            string actualHeadingText = Frames.GetIframeHeadingText();

            Assert.AreEqual(expectedHeadingText, actualHeadingText);
        }
    }
}
