using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3App
{
	class Program
	{
		static void Main(string[] args)
		{

			int mark;
			Console.Write("Please enter your mark: ");
			mark = Convert.ToInt32(Console.ReadLine());

			string yourGrade = GetGrade(mark);
			Console.WriteLine("Your grade is : " + yourGrade);
			Console.ReadKey();

			
		}
		static string GetGrade(int mark)
		{
			string grade;
			if (mark < 60)
			{
				grade = "F";
			}
			else if(mark>=60 && mark < 70)
			{
				grade = "D";
			}
			else if(mark>=70 && mark < 79)
			{
				grade = "C";
			}
			else if(mark>=80 && mark < 89)
			{
				grade = "B";
			}
			else if(mark>=90 && mark < 97)
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
