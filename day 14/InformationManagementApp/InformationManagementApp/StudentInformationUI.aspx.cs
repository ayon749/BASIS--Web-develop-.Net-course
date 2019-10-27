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
		StudentManager studentManager = new StudentManager();
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
			{
				BindAllDepartment();
			}
			//List<Student> studentList = new List<Student>();
			//studentList=studentManager.ShowAllStudent();
			//studentGridView.DataSource = studentList;
			//studentGridView.DataBind();
		}

		private void BindAllDepartment()
		{
			DepartmentManager departmentManager = new DepartmentManager();
			List<Department> departments = new List<Department>();
			departments = departmentManager.GetDepartmentName();
			ddlDepartmentList.DataTextField ="DepartmentName";
			ddlDepartmentList.DataValueField ="DepartmentId";
			ddlDepartmentList.DataSource = departments;
			ddlDepartmentList.DataBind();
		}

		protected void saveButton_Click(object sender, EventArgs e)
		{
			string name = inputStudentName.Value;
			string email = inputEmailAddress.Value;
			string regNo = inputRegNo.Value;
			string mobileNo = inputMobileNo.Value;
			int age = Convert.ToInt32(inputAge.Value);
			string address = inputAddress.Value;
			
			int deptId = Convert.ToInt32(ddlDepartmentList.SelectedValue);
			Student student = new Student(name, email, regNo, mobileNo, age, address,deptId);



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
			//List<Student> studentList = new List<Student>();
			//studentList = studentManager.ShowAllStudent();
			//studentGridView.DataSource = studentList;
			//studentGridView.DataBind();
			ClearField();
			
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

		protected void updateButton_Click(object sender, EventArgs e)
		{
			string name = inputStudentName.Value;
			string email = inputEmailAddress.Value;
			string regNo = inputRegNo.Value;
			string mobileNo = inputMobileNo.Value;
			int age = Convert.ToInt32(inputAge.Value);
			string address = inputAddress.Value;
			int deptId = Convert.ToInt32(ddlDepartmentList.SelectedValue);
			Student student = new Student(name, email, regNo, mobileNo, age, address,deptId);
			string message = studentManager.Update(student);
			successMessageLabel.Text = message;
		}

		protected void deleteButton_Click(object sender, EventArgs e)
		{
			string name = inputStudentName.Value;
			string email = inputEmailAddress.Value;
			string regNo = inputRegNo.Value;
			string mobileNo = inputMobileNo.Value;
			int age = Convert.ToInt32(inputAge.Value);
			string address = inputAddress.Value;
			int deptId = Convert.ToInt32(ddlDepartmentList.SelectedValue);
			Student student = new Student(name, email, regNo, mobileNo, age, address,deptId);
			string message=studentManager.Delete(student);
			successMessageLabel.Text = message;

		}
	}
}