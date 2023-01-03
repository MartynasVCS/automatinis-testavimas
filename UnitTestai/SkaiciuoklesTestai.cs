using NUnit.Framework;

namespace UnitTestai
{
    public class SkaiciuoklesTestai
    {
        [Test]
        public void SumosTestas()
        {
            // Duomenys
            int laukiamaSuma = 10;

            // Veiksmai
            int tikrojiSuma = Skaiciuokles.Skaiciuokles.Suma(5, 5);

            // Patikrinimas
            Assert.AreEqual(laukiamaSuma, tikrojiSuma);
        }
    }
}