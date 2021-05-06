using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class User
    {
        public User() {}
        public User(string firstName, string lastName, int id, DateTime dateOfBirth);

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public DateTime BirthDate { get; set; }

        public string FullName()
        {
            return $"{FirstName} {LastName}";
        }

        public int Age()
        {
            TimeSpan ageSpan = DateTime.Now - DateOfBirth;
            double totalAgeInYears = ageSpan.TotalDays / 365.25;
            int yearsOld = Convert.ToInt32(Math.Floor(totalAgeInYears));
            return yearsOld;
        }
    }
}
