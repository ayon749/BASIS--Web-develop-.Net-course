using InformationManagementApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InformationManagementApp.DAL
{
	public class GatewayEnrolled
	{
		string connectionString = @"Server=DESKTOP-KIQISOE\MUSHFIQSQL;Database=InformationManagementDB; Integrated Security=true;";
		public List<StudentWiseCourseEnrolledViewModel> GetEnrolledStudent()
		{
			List<StudentWiseCourseEnrolledViewModel> enrollCourseofStudent = new List<StudentWiseCourseEnrolledViewModel>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query = "SELECT * FROM StudentWiseCourseEnrolled";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				StudentWiseCourseEnrolledViewModel courseEnrolled = new StudentWiseCourseEnrolledViewModel();
				courseEnrolled.StudentName = reader["Student_Name"].ToString();
				courseEnrolled.RegNo = reader["Student_Reg_No"].ToString();
				courseEnrolled.CourseName = reader["CourseName"].ToString();
				courseEnrolled.CourseCode = reader["CourseCode"].ToString();
				courseEnrolled.EnrollDate = reader["EnrollmentDate"].ToString();
				enrollCourseofStudent.Add(courseEnrolled);

			}
			sqlConnection.Close();
			return enrollCourseofStudent;

		}
	}
}