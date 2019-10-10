using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAverageApp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the size of the array: ");
			int size =Convert.ToInt32 (Console.ReadLine());
			int[] numList = new int[size];
			Console.WriteLine("Enter integer numbers size of {0}.", size);
			for(int i = 0; i < size; i++)
			{
				numList[i] = Convert.ToInt32(Console.ReadLine());
			}
			int myAverageNumber = GetAverage(numList);
			Console.WriteLine("Average of the numers is :" + myAverageNumber);

			Console.ReadKey();

			
		}
		static int GetAverage(int[] numberAreay)
		{
			int sum = 0;
			int average;
			for (int i = 0; i < numberAreay.Length; i++)
			{
				sum += numberAreay[i];
			}
			average = sum / numberAreay.Length;
			return average;
		}
	}
}
