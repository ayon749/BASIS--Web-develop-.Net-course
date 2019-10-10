using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebClassApp
{
    [Serializable]
    public class Student
    {
        public string FirstName;
        public string LastName;
        public string UserName;
        public string RegNo;
        public string Email;
        public int Age;

        public string GetFullName()
        {
            string fullName = FirstName + " " + LastName;
            return fullName;
        }
    }
}