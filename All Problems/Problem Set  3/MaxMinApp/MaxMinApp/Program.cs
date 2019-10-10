using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinApp
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Enter the size of the array: ");
			int size = Convert.ToInt32(Console.ReadLine());
			int[] numList = new int[size];
			Console.WriteLine("Enter integer numbers size of {0}.", size);
			for (int i = 0; i < size; i++)
			{
				numList[i] = Convert.ToInt32(Console.ReadLine());
			}
			int maximumNumber = GetMaximum(numList);
			int minimumNumber = GetMinimum(numList);
			Console.WriteLine("Maximum number of this list is: " + maximumNumber);
			Console.WriteLine("Minimum number of this list is: " + minimumNumber);
			Console.ReadKey();

			
		}
		static int GetMaximum(int [] myNumberArray)
		{
			int max = myNumberArray[0];
			for(int i = 0; i < myNumberArray.Length; i++)
			{
				if (myNumberArray[i] > max)
				{
					max = myNumberArray[i];
				}
			}
			return max;
		}
		static int GetMinimum(int[] myNumberArray)
		{
			int min = myNumberArray[0];
			for (int i = 0; i < myNumberArray.Length; i++)
			{
				if (myNumberArray[i] <min)
				{
					min = myNumberArray[i];
				}
			}
			return min;
		}
	}
}
