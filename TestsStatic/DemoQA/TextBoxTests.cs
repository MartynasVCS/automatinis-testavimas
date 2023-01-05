using FrameworkStatic;
using FrameworkStatic.Pages.DemoQA;
using NUnit.Framework;

namespace TestsStatic.DemoQA
{
    internal class TextBoxTests
    {
        [SetUp]
        public void Setup()
        {
            Driver.Initialize();
            TextBox.Open();
        }

        [Test]
        public void DemoQaInputName()
        {
            string expectedOutput = "Martynas";

            TextBox.EnterFullName(expectedOutput);
            // Užbaigti sukurti metodą GetFullNameValue();
            //string actualOutput = GetFullNameValue();
            string actualOutput = "";

            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [Test]
        public void DemoQaHeaderText()
        {
            string expectedResult = "Text Box";
            string actualResult = TextBox.GetHeaderText();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.CloseDriver();
        }
    }
}
