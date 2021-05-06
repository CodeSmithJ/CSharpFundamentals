using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Calculator
    {
        public double GetSum(double numOne, double numTwo)
        {
            double sumSolution = numOne + numTwo;
            return sumSolution;

            // return numOne + numTwo;     <--- Same as ^
        }

        //subtraction

        public double GetMinus(double numOne, double numTwo)
        {
            double minSolution = numOne - numTwo;
            return minSolution;
        }
        //multiplication

        public double GetMulti(double numOne, double numTwo)
        {
            double multiSolution = numOne * numTwo;
            return multiSolution;
        }
        //division

        public double GetDivide(double numOne, double numTwo)
        {
            double divSolution = numOne / numTwo;
            return divSolution;
        }

        public int CalculateAge(DateTime birthday)
        {
            TimeSpan ageSpan = DateTime.Now - birthday;
            double totalAgeInDays = ageSpan.TotalDays;
            double totalAgeInYears = totalAgeInDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return years;
        }
    }
}
