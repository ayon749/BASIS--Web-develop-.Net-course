using Association_OnetoMany.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_OnetoMany
{
	class Program
	{
		static void Main(string[] args)
		{
			Student aStudent = new Student("Ayan", "2015-2-60-021", "01521211781", "m@gmail.com", "Dhaka");
			Student bStudent = new Student("Ayan", "2015-2-60-023", "01521211781", "m@gmail.com", "Dhaka");
			Student cStudent = new Student("Ayan", "2015-2-60-023", "01521211781", "m@gmail.com", "Dhaka");


			 Department department = new Department("CSE", 60, "6th FLoor", "Taskid Jabed");
			string message=department.AddStudent(aStudent);
			message=department.AddStudent(bStudent);
			message=department.AddStudent(cStudent);

			Console.ReadKey();

		}
	}
}
