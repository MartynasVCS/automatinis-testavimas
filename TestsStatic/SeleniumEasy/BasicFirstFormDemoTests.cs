using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;

namespace TestsStatic.SeleniumEasy
{
    internal class BasicFirstFormDemoTests
    {
        [SetUp]
        public void SetUp()
        {
            Driver.Initialize();
            BasicFirstFormDemo.Open();
        }

        [Test, Order(4)]
        public void SeleniumEasySingleInputFieldValueOnly()
        {
            string expectedResult = "Martynas";

            BasicFirstFormDemo.EnterMessage(expectedResult);
            BasicFirstFormDemo.ClickShowMessageButton();
            string actualResult = BasicFirstFormDemo.GetValueOfMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(3)]
        public void SeleniumEasySingleInputFieldFullMessage()
        {
            string message = "Martynas";
            string expectedResult = $"Your Message: {message}";

            BasicFirstFormDemo.EnterMessage(message);
            BasicFirstFormDemo.ClickShowMessageButton();
            string actualResult = BasicFirstFormDemo.GetValueOfFullMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(1)]
        public void SeleniumEasyTwoInputFields()
        {
            string valueInputA = "3";
            string valueInputB = "4";
            string expectedResult = "7";

            BasicFirstFormDemo.EnterValueA(valueInputA);
            BasicFirstFormDemo.EnterValueB(valueInputB);
            BasicFirstFormDemo.ClickGetTotalButton();
            string actualResult = BasicFirstFormDemo.GetValueOfTotal();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(2)]
        public void SeleniumEasyTwoInputFieldsNaN()
        {
            string expectedResult = "NaN";

            BasicFirstFormDemo.ClickGetTotalButton();
            string actualResult = BasicFirstFormDemo.GetValueOfTotal();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.CloseDriver();
        }
    }
}