using FrameworkStatic;
using FrameworkStatic.Pages.SeleniumEasy;
using NUnit.Framework;
using System.Collections.Generic;

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

        /// <summary>
        /// Šis testas pažymi kelis Select elemento Option elementus
        /// Tam naudojamos Selenium SelectElement klasės pagalbinės funkcijos 
        /// Tačiau, nors reikšmės vizualiai būna pažymėtos, 
        /// paspaudus mygtuką Get All Selected, grąžinama tik viena reikšmė
        /// </summary>
        [Test]
        public void MultiSelectUsingSelect()
        {
            List<string> selectionValues = new List<string> { "New York", "Florida", "Texas" };
            string expectedMessage = $"{selectionValues[0]},{selectionValues[1]},{selectionValues[2]}";

            BasicSelectDropdownDemo.SelectMultipleOptionsByText(selectionValues);
            BasicSelectDropdownDemo.ClickGetAllSelectedButton();
            string actualMessage = BasicSelectDropdownDemo.GetMultiSelectMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage),
                $"Expected '{expectedMessage}' in '{actualMessage}'");
        }

        /// <summary>
        /// Šis testas pažymi kelis Select elemento Option elementus
        /// Tam naudojam Selenium Actions klasė
        /// POM dalyje kiekvienai iš Option reikšmių pagaminamas Xpath lokatorius
        /// Xpath lokatoriai naudojami paspausti ant elementų naudojantis Actions klase
        /// Jeigu prieš pradedant žymėti elementus nėra 'nuscrolinama' prie pačio select elemento
        /// tuomet pirma reikšmė paspaudus mygtuką Get All Selected būna negrąžinama
        /// </summary>
        [Test]
        public void MultiSelectUsingActions()
        {
            List<string> selectionValues = new List<string> { "New York", "Florida", "Texas" };
            string expectedMessage = $"{selectionValues[0]},{selectionValues[1]},{selectionValues[2]}";

            BasicSelectDropdownDemo.SelectMultipleOptionsByTextUsingActions(selectionValues);
            BasicSelectDropdownDemo.ClickGetAllSelectedButton();
            string actualMessage = BasicSelectDropdownDemo.GetMultiSelectMessage();

            Assert.IsTrue(actualMessage.Contains(expectedMessage),
                $"Expected '{expectedMessage}' in '{actualMessage}'");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.CloseDriver();
        }
    }
}
