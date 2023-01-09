using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicRadioButtonDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            BasicRadioButtonDemo.Open();
        }
        
        [Test]
        public void CheckSingleRadioButtonResponseMessage()
        {
            BasicRadioButtonDemo.ClickSingleRadioMaleButton();
            BasicRadioButtonDemo.ClickGetCheckedValueButton();
            string response = BasicRadioButtonDemo.GetSingleRadioButtonResponseMessage();

            Assert.IsTrue(response.Contains("Male"));
        }

        [Test]
        public void CheckGroupRadioButtonResponseMessage()
        {
            string expectedResponse = "Sex : Male\r\nAge group: 5 - 15";

            BasicRadioButtonDemo.ClickGroupRadioMaleButton();
            BasicRadioButtonDemo.ClickGroupRadioAgeGroup5To15Button();
            BasicRadioButtonDemo.ClickGetValuesButton();
            string actualResponse = BasicRadioButtonDemo.GetGroupRadioButtonResponseMessage();

            Assert.AreEqual(expectedResponse, actualResponse);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
