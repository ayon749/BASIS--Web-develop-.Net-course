using InformationManagementApp.DAL;
using InformationManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagementApp.BLL
{
	public class StudentManager
	{
		GatewayStudent gatewayStudent = new GatewayStudent();
		public string StudentInsert(Student student)
		{
			string message;
			
			if (!gatewayStudent.isExist(student))
			{
				int rowEffect = gatewayStudent.InsertStudent(student);
				if (rowEffect > 0)
				{
					message = "Student information saved successfully!";
				}
				else
				{
					message = "Can not save information.";
				}
			}
			else
			{
				message = "Already registered a student with same Registration Number";
			}
			return message;
		}
		public List<Student> ShowAllStudent()
		{
			List<Student> studentList = new List<Student>();
				 studentList=gatewayStudent.showAllStudent();
			return studentList;
		}
	}
}