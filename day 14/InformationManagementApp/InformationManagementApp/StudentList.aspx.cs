using InformationManagementApp.BLL;
using InformationManagementApp.Models;
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
			List<Student> studentList = new List<Student>();
			studentList = studentManager.ShowAllStudent();
			studentGridView.DataSource = studentList;
			studentGridView.DataBind();
		}
	}
}