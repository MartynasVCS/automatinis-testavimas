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

        [Test]
        public void Dalyba_6_4_Double()
        {
            double expectedResult = 1.5;

            double actualResult = Skaiciuokles.Skaiciuokles.DalybaDouble(6, 4);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Dalyba_6_4_Decimal()
        {
            Assert.AreEqual(1.5m, Skaiciuokles.Skaiciuokles.DalybaDecimal(6, 4));
        }

        [Test]
        public void Dalyba_8_2_Decimal()
        {
            Assert.AreEqual(2m, Skaiciuokles.Skaiciuokles.DalybaDecimal(8, 4));
        }

        [Test]
        public void Dalyba_1_3_Decimal()
        {
            Assert.AreEqual(0.3333333333333333333333333333m, Skaiciuokles.Skaiciuokles.DalybaDecimal(1, 3));
        }

        [Test]
        public void Dalyba_1_3_Double()
        {
            Assert.AreEqual(0.33333333333333333d, Skaiciuokles.Skaiciuokles.DalybaDouble(1, 3));
        }

        [Test]
        public void Dalyba_1_10_Double()
        {
            Assert.AreEqual(0.1, Skaiciuokles.Skaiciuokles.DalybaDouble(1, 10));
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