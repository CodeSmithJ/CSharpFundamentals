using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _02_Operators
{
    [TestClass]
    public class Comparison
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            int age = 25;
            string userName = "Jacob";

            bool isEqual = age == 25; // the value of isEqual depends on the comparison

            bool userIsJesse = userName == "Micheal";

            Console.WriteLine(isEqual);
            Console.WriteLine(userIsJesse);

            bool isNotEqual = age != 23;
            Console.WriteLine(isNotEqual);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            bool listsAreEqual = firstList == secondList;
            Console.WriteLine(listsAreEqual);

            bool isGreaterThan = age > 36;
            Console.WriteLine(isGreaterThan);

            bool isLessThan = age < 36;
            Console.WriteLine(isLessThan);

            bool isGreaterorEqual = age >= 41;
            Console.WriteLine(isGreaterorEqual);

            bool isTrue = true;
            bool isFalse = false;

            bool andValue = isTrue == true && isFalse == false;

            bool anotherAndValue = age == 25 && userName == "Jacob";
            bool orValue = age == 25 || userName == "Micheal";

        }
    }
}
