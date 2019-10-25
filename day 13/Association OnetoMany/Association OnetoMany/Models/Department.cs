using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association_OnetoMany.Models
{
	class Department
	{
		public Department()
		{
			StudentList = new List<Student>();
		}

		public Department(string departmentName, int departmentId, string location, string chairperson):this()
		{
			DepartmentName = departmentName;
			DepartmentId = departmentId;
			this.location = location;
			Chairperson = chairperson;
		}

		public string DepartmentName { set; get; }
		public int DepartmentId { set; get; }
		public string location { set; get; }
		public string Chairperson { set; get; }
		public List<Student> StudentList { set; get; }
		public string AddStudent(Student student)
		{
			if (isDuplicate(student))
			{
				return "Already Exists!";
			}
			else
			{
				StudentList.Add(student);
				return "Added.";

			}
		}
		public bool isDuplicate(Student student)
		{
			foreach (Student aStudent in StudentList)
			{
				if (aStudent.StudnetId == student.StudnetId)
				{
					return true;
				}
			}
			return false;
	}
	}

}
