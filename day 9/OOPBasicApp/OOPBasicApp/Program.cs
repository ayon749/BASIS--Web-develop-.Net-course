using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasicApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person1 = new Person("Mushfiqur","Rahman");
			
			string fullName=person1.GetFullName();
			int id = person1.GetId();
			Console.WriteLine("My name is " + fullName+" and my id is "+id);

			Console.ReadKey();

			
		}
	}
}
