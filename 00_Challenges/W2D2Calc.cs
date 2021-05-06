using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_Challenges
{
    [TestClass]
    public class W2D2Calc
    {
        [TestMethod]
        public void CalcTest(string[] args)
        {
            Console.WriteLine("Number1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Addition");
            Console.WriteLine(num1 + num2);
            Console.WriteLine("Subtraction");
            Console.WriteLine(num1 - num2);
            Console.WriteLine("Multiplication");
            Console.WriteLine(num1 * num2);
            Console.WriteLine("Division");
            Console.WriteLine(num1 / num2);

            Console.ReadLine();
        }
    }
}
