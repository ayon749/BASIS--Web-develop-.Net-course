using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem4
{
	class Program
	{
		static void Main(string[] args)
		{
			double sumOfSquareNumbers, squareOfSumNumbers;
			sumOfSquareNumbers = 0;
			squareOfSumNumbers = 0;
			for(double i = 0; i <= 100; i++)
			{
				sumOfSquareNumbers += Math.Pow(i, 2);
				squareOfSumNumbers += i;

			}
			squareOfSumNumbers = Math.Pow(squareOfSumNumbers, 2);
			double diff = squareOfSumNumbers - sumOfSquareNumbers;
			Console.WriteLine("The difference between the sum of squares of the first one hundred natural numbers and the square of sum is "+diff);
			Console.ReadKey();


		}
	}
}
