using InformationManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace InformationManagementApp.DAL
{
	public class GatewayDepartment
	{
		public List<Department> GetAllDepartment()
		{
			string connectionString = @"Server=DESKTOP-KIQISOE\MUSHFIQSQL;Database=InformationManagementDB; Integrated Security=true;";
			List<Department> departments = new List<Department>();
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Department_tbl";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				int departmentId = (int)reader["DepartmentId"];
				string departmentName = reader["DepartmentName"].ToString();
				string departmentCode = reader["DepartmentCode"].ToString();
				string departmentLocation = reader["DepartmentLocation"].ToString();
				Department aDepartment = new Department(departmentId,departmentName,departmentCode,departmentLocation);
				departments.Add(aDepartment);

				
			}
			sqlConnection.Close();
			return departments;


		}
	}
}