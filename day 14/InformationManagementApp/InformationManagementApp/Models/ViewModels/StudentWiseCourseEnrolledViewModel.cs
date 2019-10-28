using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InformationManagementApp.Models.ViewModels
{
	public class StudentWiseCourseEnrolledViewModel
	{
		public StudentWiseCourseEnrolledViewModel()
		{
		}

		public StudentWiseCourseEnrolledViewModel(string studentName, string regNo, string courseName, string courseCode, string enrollDate):this()
		{
			StudentName = studentName;
			RegNo = regNo;
			CourseName = courseName;
			CourseCode = courseCode;
			EnrollDate = enrollDate;
		}

		public string StudentName { set; get; }
		public string RegNo { set; get; }
		public string CourseName { set; get; }
		public string CourseCode { set; get; }
		public string EnrollDate { set; get; }

	}
}