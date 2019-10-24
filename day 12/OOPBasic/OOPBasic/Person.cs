using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    class Person
    {
        public string FirstName, MiddleName, LastName,id;
        public Person()
        {
            id = "00000";

        }
        public Person(string FirstName,string MiddleName,string LastName):this(FirstName,LastName)
        {
          
            this.MiddleName = MiddleName;
           

        }
        public Person(string FirstName,  string LastName):this()
        {
            this.FirstName = FirstName;
            this.LastName = LastName;

        }

        public string GetFullName()
        {
            string fullName;
            if (MiddleName != null)
            {
                 fullName = FirstName + " " + MiddleName + " " + LastName;
            }
            else
            {
                fullName = FirstName + " " + LastName;
            }

            return fullName;
        }


        public string GetReverseName()
        {
            string fullName = GetFullName();
            char[] cArray = fullName.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }

    }
}
