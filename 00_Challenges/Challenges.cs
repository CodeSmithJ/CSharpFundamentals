using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges
{
    [TestClass]
    public class Challenges
    {
        [TestMethod]
        public void MorningChallengeD3()
        {
            string super = "Supercalifragilisticexpialidocious";
            foreach (char letter in super)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else if (letter == 'l')
                {
                    Console.WriteLine(letter);
                }
                else
                {
​
                Console.WriteLine("Not an 'i'");
                }
            }
            Console.WriteLine(super.Length);
            int letterCount = 0;
            foreach (char letter in super)
            {
                ++letterCount;
                //letterCount += 1;
                //letterCount = letterCount + 1;
            }
            Console.WriteLine(letterCount);

            string firstName = "Jesse";
            string lastName = "Smith";
            int myAge = 27;

            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            int plusAge = myAge + 7;
            Console.WriteLine(myAge + "7");

            List<string> favorites = new List<string>();
            string[] fav = { "Lord of the Rings", "Small Soldiers", "Dawn of the Dead", "World War Z" };
            favorites.Add("Lord of the Rings");
            favorites.Add("Small Soldiers");
            favorites.Add("Dawn of the Dead");
            favorites.Add("World War Z");

            foreach(string item in favorites)
            {
                Console.WriteLine(item);
            }

            List<DateTime> dates = new List<DateTime>();
            dates.Add(DateTime.Now);

            int hoursOfSleep = 7;
            if (hoursOfSleep >= 8)
            {
                Console.WriteLine("Wow that's a lot of sleep!");
            }
            else if (hoursOfSleep < 8 && hoursOfSleep > 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hoursOfSleep < 4 && hoursOfSleep > 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man, get some sleep!");
            }
        }
    }
}
