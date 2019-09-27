using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("All even numbers between 1 and 100 is: ");
			for(int i = 1; i <= 100; i++)
			{
				if (i % 2 == 0)
				{
					Console.WriteLine(i);
				}
			}
			
			Console.ReadKey();

			
		}
	}
}
