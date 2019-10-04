using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList myList = new ArrayList();
			myList.Add(1);
			myList.Add("abc");
			myList.Add(true);
			ArrayList newList = new ArrayList();
			newList.Add(2);
			newList = (ArrayList)myList.Clone();
			foreach(var i in newList)
			{
				Console.WriteLine(i);
			}
			ArrayList mySourceList = new ArrayList();
			mySourceList.Add("A");
			mySourceList.Add("B");
			mySourceList.Add("C");
			mySourceList.Add("D");
			mySourceList.Add("E");
			mySourceList.Add("F");

			String[] myTargetArray = new String[15];
			myTargetArray[0] = "0";
			myTargetArray[1] = "1";
			myTargetArray[2] = "2";
			myTargetArray[3] = "3";
			myTargetArray[4] = "4";
			myTargetArray[5] = "5";
			myTargetArray[6] = "6";
			myTargetArray[7] = "7";
			myTargetArray[8] = "8";
			

			// Copies the second element from the source ArrayList to the target Array starting at index 7.
			mySourceList.CopyTo(1, myTargetArray, 7, 1);
			foreach (var i in myTargetArray)
			{
				Console.WriteLine(i);
			}
			// Copies the entire source ArrayList to the target Array starting at index 6.
			mySourceList.CopyTo(myTargetArray, 6);


			Console.ReadKey();

			
		}
	}
}
