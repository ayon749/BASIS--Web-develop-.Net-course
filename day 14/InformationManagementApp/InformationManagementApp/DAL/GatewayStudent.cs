using InformationManagementApp.Models;
using InformationManagementApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InformationManagementApp.DAL
{
	public class GatewayStudent
	{
		string connectionString = @"Server=DESKTOP-KIQISOE\MUSHFIQSQL;Database=InformationManagementDB; Integrated Security=true;";
		public bool isExist(Student student)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Student_tbl WHERE Student_Reg_No='"+student.RegNo+"'";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public int InsertStudent(Student student)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query = "INSERT INTO " +
				"Student_tbl" +
	"(Student_Name" +
 ", Student_Email" +
 ", Student_Reg_No" +
 ", Student_Mobile_no" +
 ", Student_Age" +
 ", Student_Address" +
 ", DepartmentId" +
 ") VALUES ('" + student.StudentName + "','" + student.StudentEmail + "','" + student.RegNo + "','" + student.MobileNo + "','" + student.Age + "','" + student.Address + "','"+student.DepartmentId+"')";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			int rowEffect = command.ExecuteNonQuery();
			sqlConnection.Close();
			return rowEffect;
		}
		public List<DepartmentWiseStudentView> showAllStudent()
		{
			List<DepartmentWiseStudentView> studentList = new List<DepartmentWiseStudentView>();
			string connectionString = @"Server=DESKTOP-KIQISOE\MUSHFIQSQL;Database=InformationManagementDB; Integrated Security=true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query = "SELECT * FROM DepartmentWiseStudent";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				DepartmentWiseStudentView departmentWiseStudent = new DepartmentWiseStudentView();
				departmentWiseStudent.StudentName = reader["Student_Name"].ToString();
				departmentWiseStudent.RegNo = reader["Student_Reg_No"].ToString();
				departmentWiseStudent.MobileNo = reader["Student_Mobile_no"].ToString();
				departmentWiseStudent.Email = reader["Student_Email"].ToString();
				departmentWiseStudent.Address = reader["Student_Address"].ToString();
				departmentWiseStudent.Department = reader["DepartmentName"].ToString();
				departmentWiseStudent.Code = reader["DepartmentCode"].ToString();

				studentList.Add(departmentWiseStudent);


			}
			sqlConnection.Close();
			return studentList;
		}
		public int UpdateInfo(Student student)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query = @"UPDATE Student_tbl SET Student_Name = '" + student.StudentName + "', Student_Email = '" + student.StudentEmail + "', Student_Mobile_no = '" + student.MobileNo + "', Student_Address = '" + student.Address + "', Student_Age = " + student.Age + "WHERE Student_Reg_No = '" + student.RegNo + "';";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			int rowEffect = command.ExecuteNonQuery();
			sqlConnection.Close();
			return rowEffect;
		}
		public int DeleteStudent(Student student)
		{
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query="DELETE FROM Student_tbl WHERE Student_Reg_No='"+student.RegNo+"'";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			int rowEffect = command.ExecuteNonQuery();
			sqlConnection.Close();
			return rowEffect;
		}

	}
}