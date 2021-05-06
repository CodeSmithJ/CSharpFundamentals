using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Challenges
{
    public class Instuctor
    {
        public Instuctor(int employeeNumber)
        {
            EmployeeNumber = employeeNumber;
        }
        public Instuctor(string firstName, string lastName, DateTime dateOfBirth, CourseType classTaking, int employeeNumber)

        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = dateOfBirth;
            TypeOfCourse = classTaking;
            EmployeeNumber = employeeNumber;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public CourseType TypeOfCourse { get; set; }
        public int EmployeeNumber { get; set; }

    }
}
