using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _00_Challenges
{
    [TestClass]
    public class W1D4
    {
        [TestMethod]
        public void UserTest()
        {
            User person = new User("Jesse", "Smith", 007, new DateTime(1993, 06, 19));

            User secondPerson = new User();
            secondPerson.FirstName = "Jesse";
            secondPerson.LastName = "Smith";
            secondPerson.Id = 007;
            secondPerson.BirthDate = new DateTime(1993, 06, 19));
        }
    }
}
