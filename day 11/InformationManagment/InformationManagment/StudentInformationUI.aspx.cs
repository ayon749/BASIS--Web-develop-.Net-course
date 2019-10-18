using InformationManagment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InformationManagment
{
	public partial class StudentInformationUI : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			ShowAllStudentInfo();

		}

		protected void saveButton_Click(object sender, EventArgs e)
		{
			string name = inputStudentName.Value;
			string email = inputEmailAddress.Value;
			string regNo = inputRegNo.Value;
			string mobileNo = inputMobileNo.Value;
			int age = Convert.ToInt32(inputAge.Value);
			string address = inputAddress.Value;
			Student student = new Student(name, email, regNo, mobileNo, age, address);
			string connectionString = @"Server=DESKTOP-KIQISOE\MUSHFIQSQL;Database=InformationManagementDB; Integrated Security=true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query = "INSERT INTO " +
				"Student_tbl" +
	"(Student_Name" +
 ", Student_Email" +
 ", Student_Reg_No" +
 ", Student_Mobile_no" +
 ", Student_Age" +
 ", Student_Address" +
 ") VALUES ('"+student.StudentName+"','"+student.StudentEmail+"','"+student.RegNo+"','"+student.MobileNo+"','"+student.Age+"','"+student.Address+"')";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			int rowEffect=command.ExecuteNonQuery();
			sqlConnection.Close();
			if (rowEffect > 0)
			{
				successMessageLabel.Text = string.Empty;
				successMessageLabel.Text = "Student Information Saved";
				successMessageLabel.ForeColor = Color.Green;
				ClearField();
				ShowAllStudentInfo();
				
			}
			else
			{
				successMessageLabel.Text = string.Empty;
				successMessageLabel.Text = "Failed to save!";
				successMessageLabel.ForeColor = Color.Red;
			}
			
		}
		private void ShowAllStudentInfo()
		{
			List<Student> studentList = new List<Student>();
			string connectionString = @"Server=DESKTOP-KIQISOE\MUSHFIQSQL;Database=InformationManagementDB; Integrated Security=true;";
			SqlConnection sqlConnection = new SqlConnection(connectionString);
			string query = "SELECT * FROM Student_tbl ORDER BY Student_id DESC";
			SqlCommand command = new SqlCommand(query, sqlConnection);
			sqlConnection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				int studentId = (int)reader["Student_id"];
				string studentName = reader["Student_Name"].ToString();
				string studentEmail = reader["Student_Email"].ToString();
				string studentRegNo= reader["Student_Reg_No"].ToString();
				string studentMobileNo= reader["Student_Mobile_no"].ToString();
				int studentAge= (int)reader["Student_Age"];
				string studentAddress= reader["Student_Address"].ToString();
				Student student = new Student(studentName, studentEmail, studentRegNo, studentMobileNo, studentAge, studentAddress);
				student.StudentId = studentId;
				studentList.Add(student);

		
			}
			sqlConnection.Close();
			studentGridView.DataSource = studentList;
			studentGridView.DataBind();
			

		}
		protected void ClearField()
		{
			inputStudentName.Value = string.Empty;
			inputEmailAddress.Value = string.Empty;
			inputRegNo.Value = string.Empty;
			inputMobileNo.Value = string.Empty;
			inputAge.Value = string.Empty;
			inputAddress.Value = string.Empty;

		}
	}
}