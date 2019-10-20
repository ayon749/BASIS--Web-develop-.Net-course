using EmployeeInformationForm.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeInformationForm
{
	public partial class EmployeeInformationUI : System.Web.UI.Page
	{
		

		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void saveButton_Click(object sender, EventArgs e)
		{
			string name = inputEmployeeName.Value;
			string position = inputPosition.Value;
			string mobileNo = inputMobileNo.Value;
			string email = inputEmailAddress.Value;
			int salary = Convert.ToInt32(inputSalary.Value);
			int age = Convert.ToInt32(inputAge.Value);
			string address = inputAddress.Value;
			Employee employee = new Employee(name, position, mobileNo, email, salary, age, address);
			InsertEmployee(employee);
			ClearField();

		}
		public void InsertEmployee(Employee employee)
		{
			string connectionString = @"Server=DESKTOP-KIQISOE\MUSHFIQSQL;Database=EmployeeManagementSystemDB;Integrated Security=true;";
			SqlConnection conncetion = new SqlConnection(connectionString);
			string qeury = "INSERT INTO Employee_tbl(" +
				"EmployeeName," +
	" EmplyeePosition," +
 " EmployeeMobileNo," +
 " EmployeeEmail, " +
 "EmployeeSalary," +
 " EmployeeAge, " +
 "EMployeeAddress)" +
				"VALUES('"+employee.EmployeeName+"','"+employee.EmployeePosition+"','"+employee.EmployeeMobileNo+"','"+employee.EmployeeEmail+"','"+employee.EmployeeSalary+"','"+employee.EmployeeAge+"','"+employee.EmployeeAddress+"')";
			SqlCommand command = new SqlCommand(qeury, conncetion);
			conncetion.Open();
			int rowEffect = command.ExecuteNonQuery();
			conncetion.Close();
			if (rowEffect > 0)
			{
				showMessage.Text = string.Empty;
				showMessage.Text = "Employee Information saved Successfully";
				showMessage.ForeColor = Color.Green;
			}
			else
			{
				showMessage.Text = string.Empty;
				showMessage.Text = "Can not save this Information";
				showMessage.ForeColor = Color.Red;
			}

		}
		public void ClearField()
		{
			inputEmployeeName.Value = string.Empty;
			inputPosition.Value = string.Empty;
			inputMobileNo.Value = string.Empty;
			inputEmailAddress.Value = string.Empty;
			inputSalary.Value = string.Empty;
			inputAge.Value = string.Empty;
			inputAddress.Value = string.Empty;
		}
	}
}