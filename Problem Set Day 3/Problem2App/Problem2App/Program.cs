using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2App
{
	class Program
	{
		static void Main(string[] args)
		{

			int[] numList = new int[5];
			Console.WriteLine("Please enter 5 integer numbers: ");
			for(int i = 0; i < 5; i++)
			{
				numList[i] = Convert.ToInt32(Console.ReadLine());
			}

			int average = GetAverage(numList);
			Console.WriteLine("The average is : " + average);
			Console.ReadKey();

			 
		}
		static int GetAverage(int [] numbers)
		{
			int average ;
			int sum = 0;
			for(int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}
			average = sum / numbers.Length;
			return average;
		}

	}
}
