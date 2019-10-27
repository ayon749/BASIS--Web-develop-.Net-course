using InformationManagementApp.BLL;
using InformationManagementApp.Models;
using InformationManagementApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InformationManagementApp
{
	public partial class Student_List : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			StudentManager studentManager = new StudentManager();
			List<DepartmentWiseStudentView> studentList = new List<DepartmentWiseStudentView>();
			studentList = studentManager.ShowAllStudent();
			studentGridView.DataSource = studentList;
			studentGridView.DataBind();
		}
	}
}