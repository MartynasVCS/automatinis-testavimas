using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;
using TestsStatic.BaseClasses;

// Leidžia nustatyti kiek paralelinių procesų norime turėti
// Pagal nutylėjimą: branduolių skaičius arba 2 (kuris didesnis)
[assembly: LevelOfParallelism(3)]
namespace TestsStatic.SeleniumEasy
{

    // Šitaip padarome, kad klasėje esantys testai galėtų veikti paraleliai
    [Parallelizable(scope: ParallelScope.Children)]
    internal class BasicFirstFormDemoTests : BaseTest
    {
        [SetUp]
        public void Open()
        {
            BasicFirstFormDemo.Open();
        }

        [Test, Order(3)]
        public void SeleniumEasySingleInputFieldValueOnly()
        {
            string expectedResult = "Martynas";

            BasicFirstFormDemo.EnterMessage(expectedResult);
            BasicFirstFormDemo.ClickShowMessageButton();
            string actualResult = BasicFirstFormDemo.GetValueOfMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Order(2)]
        public void SeleniumEasySingleInputFieldFullMessage()
        {
            string message = "Martynas";
            string expectedResult = $"Your Message: {message}";

            BasicFirstFormDemo.EnterMessage(message);
            BasicFirstFormDemo.ClickShowMessageButton();
            string actualResult = BasicFirstFormDemo.GetValueOfFullMessage();

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("3", "4", "7")]
        [TestCase("5", "4", "9")]
        [TestCase("a", "4", "NaN")]
        [TestCase("4", "c", "NaN")]
        [TestCase("d", "c", "NaN")]
        [TestCase("", "", "NaN")]
        [Test, Order(1)]
        public void SeleniumEasyTwoInputFields(string valueInputA, string valueInputB, string expectedResult)
        {
            if (valueInputA != "")
            {
                BasicFirstFormDemo.EnterValueA(valueInputA);
            }
            if (valueInputB != "")
            {
                BasicFirstFormDemo.EnterValueB(valueInputB);
            }
            BasicFirstFormDemo.ClickGetTotalButton();
            string actualResult = BasicFirstFormDemo.GetValueOfTotal();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}