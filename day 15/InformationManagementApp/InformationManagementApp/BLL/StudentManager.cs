using InformationManagementApp.DAL;
using InformationManagementApp.Models;
using InformationManagementApp.Models.ViewModels;
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
		public List<DepartmentWiseStudentView> ShowAllStudent()
		{
			List<DepartmentWiseStudentView> studentList = new List<DepartmentWiseStudentView>();
				 studentList=gatewayStudent.showAllStudent();
			return studentList;
		}
		public string Update(Student student)
		{
			string message;

			if (gatewayStudent.isExist(student))
			{
				int rowEffect = gatewayStudent.UpdateInfo(student);
				if (rowEffect > 0)

					message = "Student information updated successfully!";
				else
					message = "Can not update";
			}
			else
			{
				message = "No student exist with this registration number";
			}
			return message;
		}
		public string Delete(Student student)
		{
			string message;
			int row=gatewayStudent.DeleteStudent(student);
			if (row > 0)
			{
				message = "Succesfully deleted student";
				
			}
			else
			{
				message = "Can not find student";
			}
			return message;
		}
	}
}