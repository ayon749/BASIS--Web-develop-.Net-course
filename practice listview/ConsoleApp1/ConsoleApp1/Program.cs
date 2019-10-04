using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			List<int> myList = new List<int>();
			myList.Add(1);
			myList.Add(1);
			myList.Add(1);
			int[] arr = new int[4];
			arr[0] = 500;
			arr[1] = 600;
			arr[2] = 700;
			arr[3] = 800;
			myList.AddRange(arr);
			myList.Remove(500);
			foreach (int i in myList)
			{
				Console.WriteLine(i);
			}
			List<string> subjects = new List<string>();
			subjects.Add("Physics");
			subjects.Add("Chemistry");
			subjects.Add("Biology");
			subjects.Add("Science");
			
			subjects.RemoveAt(2);
			foreach (string i in subjects)
			{
				Console.WriteLine(i);
			}



			Console.ReadKey();

			
		}
	}
}
