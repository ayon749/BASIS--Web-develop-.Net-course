using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1, num2, upper, lower;
			Console.WriteLine("Please enter the 1st Integer Number: ");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Please enter the 2nd Integer Number: ");
			num2 = Convert.ToInt32(Console.ReadLine());
			if (num1 < num2)
			{
				lower = num1;
				upper = num2;
			}
			else
			{
				lower = num2;
				upper = num1;
			}
			Console.WriteLine("All integer numbers between {0} and {1} is (including them)", lower, upper);
			for(int i = lower; i <=upper; i++)
			{
					Console.WriteLine(i);
			}

			Console.ReadKey();
		}
	}
}
