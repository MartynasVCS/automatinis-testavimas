using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestai
{
    internal class NamuDarboTestai
    {
        [Test]
        public void Testas1()
        {
            // Testas “žalias” jeigu 995 dalijasi iš 3 (be liekanos)
            int expectedResult = 0;
            int actualResult = 995 % 3;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Testas2()
        {
            // Testas “žalias” jeigu šiandien trečiadienis
            DayOfWeek expectedResult = DayOfWeek.Wednesday;

            DateTime today = DateTime.Today;
            DayOfWeek actualResult = today.DayOfWeek;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Testas3()
        {
            // Testas “žalias” jeigu dabar yra 13h 
            int expectedResult = 13;

            DateTime now = DateTime.Now;
            int actualResult = now.Hour;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Testas4()
        {
            // Bonus: Testas “žalias” jei nuo 1 iki 10 yra 4 lyginiai skaičiai
            int expectedResult = 4;

            int actualResult = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    actualResult++;
                }
            }

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
