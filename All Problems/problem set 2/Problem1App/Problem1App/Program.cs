using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1App
{
	class Program
	{
		static void Main(string[] args)
		{
			string fName, mName, lName;
			Console.Write("Enter the First Name: ");
			fName = Console.ReadLine();
			Console.Write("Enter the Middle Name: ");
			mName = Console.ReadLine();
			Console.Write("Enter the Last Name: ");
			lName = Console.ReadLine();
			string fullName = GetFullName(fName, mName, lName);
			Console.WriteLine(fullName);

			Console.ReadKey();
			


		}
		static string GetFullName(string firstName, string middleName,string lastName)
		{
			string fullName = "Full name is: " + firstName + " " + middleName + " " + lastName;
			return fullName;
		}
		
			
		}
	

	
}
