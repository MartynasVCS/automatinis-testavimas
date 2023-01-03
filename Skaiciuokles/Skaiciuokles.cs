using System;

namespace Skaiciuokles
{
    public class Skaiciuokles
    {
        public static int SudetisInt(int sk1, int sk2)
        {
            return sk1 + sk2;
        }

        public static double SudetisDouble2(double sk1, double sk2)
        {
            return (double)sk1 + sk2;
        }

        public static double SudetisDouble3(double sk1, double sk2, double sk3)
        {
            return (double)sk1 + sk2 + sk3;
        }

        public static decimal SudetisDecimal3(decimal sk1, decimal sk2, decimal sk3)
        {
            return sk1 + sk2 + sk3;
        }

        public static int Atimtis(int sk1, int sk2)
        {
            return sk1 - sk2;
        }

        public static int Daugyba(int sk1, int sk2)
        {
            return sk1 * sk2;
        }

        public static decimal DalybaDecimal(int sk1, int sk2)
        {
            return (decimal)sk1 / sk2;
        }

        public static double DalybaDouble(int sk1, int sk2) 
        { 
            return (double)sk1 / sk2;
        }
    }
}
