using FrameworkStatic;
using FrameworkStatic.Pages.OmayoBlogspot;
using NUnit.Framework;

namespace TestsStatic.OmayoBlogspot
{
    internal class HomePageTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            HomePage.Open();
        }

        [Test]
        public void EnterTextToHtmlFormUserName()
        {
            string expectedResult = "Martynas";

            HomePage.EnterHtmlFormUserName(expectedResult);
            string actualResult = HomePage.GetValueOfHtmlFormUserName();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ClearAndEnterTextToTextBoxWithPreloadedText()
        {
            string expectedResult = "Martynas";

            HomePage.ClearTextBoxWithPreloadedText();
            HomePage.EnterToTextBoxWithPreloadedText(expectedResult);
            string actualResult = HomePage.GetValueOfTextBoxWithPreloadedText();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void FileUpload()
        {
            string expectedResult = "Driver.cs";

            HomePage.SetFileForUpload();
            string actualResult = HomePage.GetSelectedFileName();

            Assert.IsTrue(actualResult.Contains(expectedResult));
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}