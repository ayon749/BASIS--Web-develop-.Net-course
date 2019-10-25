using InformationManagementApp.BLL;
using InformationManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InformationManagementApp
{
	public partial class StudentInformationUI : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

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
			StudentManager studentManager = new StudentManager();
			string message=studentManager.StudentInsert(student);
			if(message== "Student information saved successfully!")
			{
				successMessageLabel.Text = message;
				successMessageLabel.ForeColor = Color.Green;
			}
			else
				{
				successMessageLabel.Text = message;
				successMessageLabel.ForeColor = Color.Red;

			}
		}
	}
}