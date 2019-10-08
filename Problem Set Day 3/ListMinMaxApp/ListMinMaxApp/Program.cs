using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMinMaxApp
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> numberList = new List<int>();
			Console.WriteLine("Enter the size of the list: ");
			int size = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the list of size {0} ", size);
			for(int i = 0; i < size; i++)
			{
				int number = Convert.ToInt32(Console.ReadLine());
				numberList.Add(number);
			}

			int maximumNumber = GetMaxNumber(numberList);
			Console.WriteLine("Maximum number is: "+ maximumNumber);
			int minimumNumber = GetMinNumber(numberList);
			Console.WriteLine("Minimum number is: " + minimumNumber);
			Console.ReadKey();

			
		}
		static int GetMaxNumber(List<int> numberArray)
		{
			int max = numberArray[0];
			foreach(int number in numberArray)
			{
				if(number> max)
				{
					max = number;
				}
			}
			return max;
		}
		static int GetMinNumber(List<int> numberArray)
		{
			int min = numberArray[0];
			foreach (int number in numberArray)
			{
				if (number < min)
				{
					min = number;
				}
			}
			return min;
		}
	}
}
