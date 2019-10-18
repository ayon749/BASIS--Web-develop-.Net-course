using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagment.Models
{
	public class Student
	{
		public int StudentId { get; set; }
		public string StudentName { get; set; }
		public string StudentEmail { get; set; }
		public string RegNo { get; set; }
		public string MobileNo { get; set; }
		public int Age { get; set; }
		public string Address { get; set; }

		public Student(string studentName,string studentEmail,string regNo,string mobileNo,int age,string address)
		{
			StudentName = studentName;
			StudentEmail = studentEmail;
			RegNo = regNo;
			MobileNo = mobileNo;
			Age = age;
			Address = address;
		}
	}
}
