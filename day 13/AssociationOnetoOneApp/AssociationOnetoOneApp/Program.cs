using AssociationOnetoOneApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssociationOnetoOneApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Address aAddress = new Address("44", "14", "Merul Badda", 1212, "Dhaka");
			Person person = new Person("Md.", "Ataur", "Rahman", aAddress);
			person.Display();
			
			Console.ReadKey();

		
		}
	}
}
