using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Sakib","Al","Hasan");
         
            string fullName = person1.GetFullName();
            string reverseName = person1.GetReverseName();
            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);
            Console.WriteLine(" ");

            Person person2 = new Person("Mushfiqur","Rahman");
          
             fullName = person2.GetFullName();
            reverseName = person2.GetReverseName();
            Console.WriteLine(fullName);
            Console.WriteLine(reverseName);

            Person person3 = new Person();
            Console.ReadKey();

           
        }
    }
}
