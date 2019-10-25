using InformationManagementApp.Models;
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
 ") VALUES ('" + student.StudentName + "','" + student.StudentEmail + "','" + student.RegNo + "','" + student.MobileNo + "','" + student.Age + "','" + student.Address + "')";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			int rowEffect = command.ExecuteNonQuery();
			sqlConnection.Close();
			return rowEffect;
		}

	}
}