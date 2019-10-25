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
		public string StudentInsert(Student student)
		{
			GatewayStudent gatewayStudent = new GatewayStudent();
			int rowEffect=gatewayStudent.InsertStudent(student);
			if (rowEffect > 0)
			{
				return "Student information saved successfully!";
			}
			else
			{
				return "Can not save information.";
			}
		}
	}
}