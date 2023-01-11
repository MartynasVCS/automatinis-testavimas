using NUnit.Framework;

namespace UnitTestai
{
    public class SkaiciuoklesTestai
    {
        [Test]
        public void Sudetis_5_5_Int()
        {
            int laukiamaSuma = 10;

            int tikrojiSuma = Skaiciuokles.Skaiciuokles.SudetisInt(5, 5);

            Assert.AreEqual(laukiamaSuma, tikrojiSuma);
        }

        [Test]
        public void Atimtis_15_5_Int()
        {
            int expectedResult = 10;

            int actualResult = Skaiciuokles.Skaiciuokles.Atimtis(15, 5);

            Assert.IsTrue(expectedResult == actualResult,
                $"Tikėjausi: {expectedResult}, gavau: {actualResult}");
        }

        [Test]
        public void Daugyba_4_2_Int()
        {
            int expectedResult = 8;

            int actualResult = Skaiciuokles.Skaiciuokles.Daugyba(4, 2);

            Assert.AreEqual(expectedResult, actualResult);
        }

        /// <summary>
        /// TestCase anotacija nepalaido decimal tipo!!!
        /// </summary>
        [TestCase(6, 4, 1.5)]
        [TestCase(8, 4, 2)]
        [TestCase(1, 3, 0.3333333333333333333333333333)]
        [Test]
        public void Dalyba_Decimal(int sk1, int sk2, decimal rez)
        {
            Assert.AreEqual(rez, Skaiciuokles.Skaiciuokles.DalybaDecimal(sk1, sk2));
        }

        [TestCase(1, 10, 0.1d)]
        [TestCase(6, 4, 1.5d)]
        [TestCase(1, 3, 0.33333333333333333d)]
        [Test]
        public void Dalyba_1_3_Double(int sk1, int sk2, double dalmuo)
        {
            Assert.AreEqual(dalmuo, Skaiciuokles.Skaiciuokles.DalybaDouble(sk1, sk2));
        }

        [Test]
        public void Sudetis_01_01_Double()
        {
            Assert.AreEqual(0.2d, Skaiciuokles.Skaiciuokles.SudetisDouble2(0.1, 0.1));
        }

        [Test]
        public void Sudetis_01_01_01_Double()
        {
            // Testas "feilina" dėl double tipo netikslumo
            Assert.AreEqual(0.3d, Skaiciuokles.Skaiciuokles.SudetisDouble3(0.1, 0.1, 0.1));
        }

        [Test]
        public void Sudetis_01_01_01_Decimal()
        {
            // Testas "nefeilina" nes naudojamas tikslesnis decimal tipas
            Assert.AreEqual(0.3m, Skaiciuokles.Skaiciuokles.SudetisDecimal3(0.1m, 0.1m, 0.1m));
        }
    }
}