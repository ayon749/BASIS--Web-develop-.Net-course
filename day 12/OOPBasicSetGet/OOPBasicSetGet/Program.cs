using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicSetGet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            string firstName = Console.ReadLine();
            string middleName = Console.ReadLine();
            string lastName = Console.ReadLine();
            person1.FirstName = firstName; ;
            person1.MiddleName=middleName;
            person1.LastName = lastName; ;
            string fName = person1.FirstName;
            string mName = person1.MiddleName;
            string lName = person1.LastName;

            Console.ReadKey();

           
        }
    }
}
