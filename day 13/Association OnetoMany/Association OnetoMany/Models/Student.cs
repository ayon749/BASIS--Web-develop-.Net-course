using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_OnetoMany.Models
{
	class Student
	{
		public Student()
		{

		}

		public Student(string studentName, string studnetId, string mobileNo, string email, string address):this()
		{
			StudentName = studentName;
			StudnetId = studnetId;
			MobileNo = mobileNo;
			Email = email;
			Address = address;
		}

		public string StudentName { set; get; }
		public string StudnetId { set; get; }
		public string MobileNo { set; get; }
		public string Email { set; get; }
		public string Address { set; get; }
	}
}
