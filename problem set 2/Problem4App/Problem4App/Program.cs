using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4App
{
	class Program
	{
		static void Main(string[] args)
		{
			string i;
			string fName, lName, subject;
			int mark;
			i = "y";
			while (i == "y")

			{
				if (i == "n")
				{
					break;
				}
				Console.WriteLine("Enter First Name : ");
				fName = Console.ReadLine();
				Console.WriteLine("Enter Last Name : ");
				lName = Console.ReadLine();
				Console.WriteLine("Enter Subject : ");
				subject = Console.ReadLine();
				Console.WriteLine("Enter Mark : ");
				mark = Convert.ToInt32(Console.ReadLine());

				string grade = GetGrade(mark);
				string FullName = GetFullName(fName, lName);
				string message;

				if (grade == "F")
				{
					message = "Sorry! you have failed.Please try again!";

				}
				else
				{
					message = FullName + " Congratulations! You have passed in " + subject + " and your grade is " + '"' + grade + '"';
				}
				Console.WriteLine(message);
				Console.WriteLine();
				Console.WriteLine();

				Console.WriteLine();
				Console.WriteLine("Do you want to continue (y/n)?");
				i=Console.ReadLine();
			}


			Console.ReadKey();

		}
		static string GetFullName(string firstName,String lastName)
		{
			string fullName = "Hello " + firstName + " " + lastName+".";
			return fullName;
		}
		static string GetGrade(int mark)
		{
			string grade;
			if (mark < 60)
			{
				grade = "F";
			}
			else if(mark>=60 && mark <= 70)
			{
				grade = "D";
			}
			else if (mark >= 71 && mark <= 80)
			{
				grade = "C";
			}
			else if (mark >= 81 && mark <= 90)
			{
				grade = "B";
			}
			else if (mark >= 91 && mark <= 97)
			{
				grade = "A";
			}
			else
			{
				grade = "A+";
			}
			return grade;
		
		}
	}
}
