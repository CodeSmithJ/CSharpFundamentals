using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public enum CourseType { CyberSecurity, SoftwareDevelopment, WebDevelopment }
    public enum BadgeType { White, Gold, Red, Blue }
    public class Student
    {
        public Student() { }
        public Student(string firstName, string lastName, DateTime dateOfBirth, CourseType classTaking, decimal amountDue, BadgeType typeOfBadge, bool passedClass)

        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = dateOfBirth;
            TypeOfCourse = classTaking;
            BalanceOwed = amountDue;
            TypeOfBadge = typeOfBadge;
            HasGraduated = passedClass;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public CourseType TypeOfCourse { get; set; }
        public decimal BalanceOwed { get; set; }
        public BadgeType TypeOfBadge { get; set; }
        public bool HasGraduated { get; set; }

    }
}
