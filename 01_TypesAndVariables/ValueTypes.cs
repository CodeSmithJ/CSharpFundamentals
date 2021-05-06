using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _01_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;

            isDeclared = true; // Initializing the variable

            bool isDeclaredAndInitialized = false;
        }

        [TestMethod]
        public void Characters()
        {
            char letter = 'a';
            char numberCharacter = '7';
            char symbol = '?';
            char space = ' ';
            char specialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExample = 255;
            short shortExample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = -2147483648;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.2545664484682641515458f;
            double doubleExample = 1.2545664484682641515458d;
            decimal decimalExample = 1.2545664484682641515458m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);
        }

        enum PastryType { Cake, Cupcake, Eclaire, Danish, Canoli}

        [TestMethod]
        public void Enum()
        {
            PastryType myPastry = PastryType.Eclaire;
            PastryType anotherPastry = PastryType.Danish;
        }

        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            Console.WriteLine(DateTime.Now);
            DateTime birthday = new DateTime(1993, 06, 19);

            TimeSpan age = today - birthday;
            int ageInDays = age.Days;

            Console.WriteLine(ageInDays / 365);
        }
    }
}
